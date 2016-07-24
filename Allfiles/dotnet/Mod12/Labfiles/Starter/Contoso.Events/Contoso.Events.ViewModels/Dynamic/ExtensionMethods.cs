using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;

namespace Contoso.Events.ViewModels.Dynamic
{
    public static class ExtensionMethods
    {
        public static PropertyBuilder DefinePublicProperty(this TypeBuilder target, string name, Type targetType)
        {
            FieldBuilder backingField = target.DefineField(String.Format("_{0}", name), targetType, FieldAttributes.Private);
            PropertyBuilder property = target.DefineProperty(name, System.Reflection.PropertyAttributes.HasDefault, targetType, null);

            //Getter
            {
                MethodBuilder getMethod = target.DefineMethod(String.Format("get_{0}", name), MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                    targetType, Type.EmptyTypes);
                ILGenerator getMethodIL = getMethod.GetILGenerator();

                getMethodIL.Emit(OpCodes.Ldarg_0);					// Load "this"
                getMethodIL.Emit(OpCodes.Ldfld, backingField);		// Load the property's underlying field onto the stack
                getMethodIL.Emit(OpCodes.Ret);						// Return the value on the stack

                property.SetGetMethod(getMethod);
            }

            //Setter
            {
                MethodBuilder setMethod = target.DefineMethod("set_FirstNum", MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                    null, new Type[] { targetType });
                ILGenerator setMethodIL = setMethod.GetILGenerator();

                setMethodIL.Emit(OpCodes.Ldarg_0);					// Load "this"
                setMethodIL.Emit(OpCodes.Ldarg_1);					// Load "value" onto the stack
                setMethodIL.Emit(OpCodes.Stfld, backingField);		// Set the field equal to the "value" on the stack
                setMethodIL.Emit(OpCodes.Ret);						// Return nothing

                property.SetSetMethod(setMethod);
            }

            return property;
        }

        public static dynamic ToDynamic(this object value)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(value.GetType()))
                expando.Add(property.Name, property.GetValue(value));

            return expando as ExpandoObject;
        }
    }
}