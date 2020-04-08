// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MachineDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MachineDtoType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Template")]
        Template
    }
    internal static class MachineDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this MachineDtoType? value)
        {
            return value == null ? null : ((MachineDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MachineDtoType value)
        {
            switch( value )
            {
                case MachineDtoType.Standard:
                    return "Standard";
                case MachineDtoType.Template:
                    return "Template";
            }
            return null;
        }

        internal static MachineDtoType? ParseMachineDtoType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return MachineDtoType.Standard;
                case "Template":
                    return MachineDtoType.Template;
            }
            return null;
        }
    }
}
