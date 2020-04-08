// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SimpleUserDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SimpleUserDtoType
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Robot")]
        Robot
    }
    internal static class SimpleUserDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this SimpleUserDtoType? value)
        {
            return value == null ? null : ((SimpleUserDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SimpleUserDtoType value)
        {
            switch( value )
            {
                case SimpleUserDtoType.User:
                    return "User";
                case SimpleUserDtoType.Robot:
                    return "Robot";
            }
            return null;
        }

        internal static SimpleUserDtoType? ParseSimpleUserDtoType(this string value)
        {
            switch( value )
            {
                case "User":
                    return SimpleUserDtoType.User;
                case "Robot":
                    return SimpleUserDtoType.Robot;
            }
            return null;
        }
    }
}
