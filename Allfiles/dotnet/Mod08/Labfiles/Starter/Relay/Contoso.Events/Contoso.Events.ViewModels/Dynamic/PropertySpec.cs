using System;

namespace Contoso.Events.ViewModels.Dynamic
{
    public class PropertySpec : Tuple<Type, string, string, string>
    {
        public PropertySpec(Type targetType, string name, string displayName = "", string group = "")
            : base(targetType, name, displayName != null ? displayName : name, group ?? String.Empty)
        { }

        public Type TargetType { get { return base.Item1; } }

        public String TypeName { get { return base.Item2; } }

        public String DisplayName { get { return base.Item3; } }

        public String Group { get { return base.Item4; } }
    }

    public class PropertySpec<T> : PropertySpec
    {
        public PropertySpec(string name, string displayName = "", string group = "")
            : base(typeof(T), name, displayName, group)
        { }
    }
}