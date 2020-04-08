// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StopJobParametersEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StopJobParametersEnum
    {
        [EnumMember(Value = "SoftStop")]
        SoftStop,
        [EnumMember(Value = "Kill")]
        Kill
    }
    internal static class StopJobParametersEnumEnumExtension
    {
        internal static string ToSerializedValue(this StopJobParametersEnum? value)
        {
            return value == null ? null : ((StopJobParametersEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StopJobParametersEnum value)
        {
            switch( value )
            {
                case StopJobParametersEnum.SoftStop:
                    return "SoftStop";
                case StopJobParametersEnum.Kill:
                    return "Kill";
            }
            return null;
        }

        internal static StopJobParametersEnum? ParseStopJobParametersEnum(this string value)
        {
            switch( value )
            {
                case "SoftStop":
                    return StopJobParametersEnum.SoftStop;
                case "Kill":
                    return StopJobParametersEnum.Kill;
            }
            return null;
        }
    }
}
