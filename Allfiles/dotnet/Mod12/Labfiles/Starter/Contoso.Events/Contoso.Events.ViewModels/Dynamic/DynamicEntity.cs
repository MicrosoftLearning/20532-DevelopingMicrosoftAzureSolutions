using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.ViewModels.Dynamic
{
    public static class DynamicEntity
    {
        private static Type TargetType = typeof(Registration);

        public static dynamic GenerateDynamicItem(DynamicTableEntity actualItem)
        {
            // Parse EdmTypes
            IEnumerable<PropertySpec> types = actualItem.Properties
                            .Where(p => TargetType.GetProperty(p.Key) == null)
                            .Select(p => new PropertySpec(Type.GetType("System." + p.Value.PropertyType.ToString()), p.Key));

            Type targetType = DynamicTypeFactory.GenerateDynamicType(TargetType, false, types.ToArray<PropertySpec>());

            dynamic dynamicItem = DynamicTypeFactory.GenerateCustomItem(targetType);

            return PopulateDynamicItem(targetType, actualItem, dynamicItem);
        }

        public static dynamic GenerateDynamicItem(JToken actualItem)
        {
            var propDict = actualItem.Cast<JProperty>().Where(p => p.Name.StartsWith("RegistrationStub.")).ToDictionary(p => p.Name.Replace("RegistrationStub.", String.Empty), p => p.Value);

            IEnumerable<PropertySpec> types = propDict.Select(p => new PropertySpec(GetType(p.Value), p.Key));

            Type targetType = DynamicTypeFactory.GenerateDynamicType(TargetType, true, types.ToArray<PropertySpec>());

            dynamic dynamicItem = DynamicTypeFactory.GenerateCustomItem(targetType);

            return PopulateDynamicItem(targetType, actualItem, dynamicItem);
        }

        public static dynamic PopulateDynamicItem(Type targetType, DynamicTableEntity actualItem, dynamic dynamicItem)
        {
            foreach (var property in targetType.GetProperties().Where(p => p.SetMethod != null))
            {
                var actualCustomProperties = actualItem.Properties.Where(p => p.Key == property.Name);
                if (actualCustomProperties.Any())
                {
                    var actualCustomProperty = actualCustomProperties.Single();
                    var value = typeof(EntityProperty).GetProperty(actualCustomProperty.Value.PropertyType.ToString() + "Value").GetValue(actualCustomProperty.Value);
                    property.SetValue(dynamicItem, value);
                }
                else
                {
                    var actualProperty = typeof(DynamicTableEntity).GetProperty(property.Name);
                    if (actualProperty != null)
                    {
                        var value = actualProperty.GetValue(actualItem);
                        property.SetValue(dynamicItem, value);
                    }
                }
            }

            return dynamicItem;
        }
        public static dynamic PopulateDynamicItem(Type targetType, JToken actualItem, dynamic dynamicItem)
        {
            var propDict = actualItem.Cast<JProperty>().ToDictionary(p => p.Name, p => p.Value);

            foreach (var property in targetType.GetProperties().Where(p => p.SetMethod != null))
            {
                if (propDict.ContainsKey(property.Name))
                {
                    JToken token = propDict[property.Name];
                    Type type = GetType(token);
                    if (type != typeof(DateTimeOffset))
                    {
                        var value = Convert.ChangeType(token.ToString(), type);
                        property.SetValue(dynamicItem, value);
                    }
                }
                else if (propDict.ContainsKey("RegistrationStub." + property.Name))
                {
                    JToken token = propDict["RegistrationStub." + property.Name];
                    Type type = GetType(token);
                    if (type != typeof(DateTimeOffset))
                    {
                        var value = Convert.ChangeType(token.ToString(), type);
                        property.SetValue(dynamicItem, value);
                    }
                }
            }

            dynamicItem.PartitionKey = propDict["Event.EventKey"].ToString();
            dynamicItem.RowKey = Guid.NewGuid().ToString();

            return dynamicItem;
        }

        private static Type GetType(JToken target)
        {
            switch (target.Type)
            {
                case JTokenType.Integer:
                    return typeof(System.Int32);
                case JTokenType.Boolean:
                    return typeof(System.Boolean);
                case JTokenType.Date:
                    return typeof(System.DateTimeOffset);
                case JTokenType.String:
                default:
                    return typeof(System.String);
            }
        }
    }
}