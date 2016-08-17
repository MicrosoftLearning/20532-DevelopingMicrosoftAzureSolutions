using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace Contoso.Events.ViewModels.Dynamic
{
    public class DynamicTypeFactory
    {
        public static Type GenerateDynamicType(Type baseType, bool avoidDuplicates = false, params PropertySpec[] properties)
        {
            AssemblyBuilder assemblyBuilder = Thread.GetDomain().DefineDynamicAssembly(
                  new AssemblyName("DynamicModule"),
                  AssemblyBuilderAccess.Run
            );

            string newTypeName = String.Format("{0}Extended", baseType.FullName);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicModuleTest");
            TypeBuilder typeBuilder = moduleBuilder.DefineType(
                  newTypeName,
                  TypeAttributes.Public,
                  baseType
            );

            typeBuilder.DefineDefaultConstructor(MethodAttributes.Public);

            typeBuilder = AddProperties(typeBuilder, avoidDuplicates, properties);

            Type dynamicType = typeBuilder.CreateType();

            return dynamicType;
        }

        public static dynamic GenerateCustomItem(Type targetType)
        {
            return Convert.ChangeType(
                Activator.CreateInstance(targetType),
                targetType
            );
        }

        public static dynamic GenerateCustomItem<TargetType>()
        {
            return GenerateCustomItem(typeof(TargetType));
        }

        private static TypeBuilder AddProperties(TypeBuilder typeBuilder, bool avoidDuplicates, IEnumerable<PropertySpec> properties = null)
        {
            if (properties != null)
            {
                foreach (var property in properties)
                {
                    if (avoidDuplicates)
                    {
                        if (typeof(Registration).GetProperty(property.TypeName) != null)
                        {
                            continue;
                        }
                    }

                    PropertyBuilder resultProperty = typeBuilder.DefinePublicProperty(property.TypeName, property.TargetType);

                    if (!String.IsNullOrEmpty(property.DisplayName) || !String.IsNullOrEmpty(property.Group))
                    {
                        resultProperty.SetCustomAttribute(
                            new CustomAttributeBuilder(
                                typeof(DisplayAttribute).GetConstructor(Type.EmptyTypes),
                                new object[] { },
                                new PropertyInfo[] { typeof(DisplayAttribute).GetProperty("Name"), typeof(DisplayAttribute).GetProperty("GroupName") },
                                new object[] { property.DisplayName, property.Group }
                            )
                        );
                    }
                }
            }

            return typeBuilder;
        }
    }
}