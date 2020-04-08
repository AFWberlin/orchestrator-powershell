// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StartProcessDtoSource.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StartProcessDtoSource
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Schedule")]
        Schedule
    }
    internal static class StartProcessDtoSourceEnumExtension
    {
        internal static string ToSerializedValue(this StartProcessDtoSource? value)
        {
            return value == null ? null : ((StartProcessDtoSource)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StartProcessDtoSource value)
        {
            switch( value )
            {
                case StartProcessDtoSource.Manual:
                    return "Manual";
                case StartProcessDtoSource.Schedule:
                    return "Schedule";
            }
            return null;
        }

        internal static StartProcessDtoSource? ParseStartProcessDtoSource(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return StartProcessDtoSource.Manual;
                case "Schedule":
                    return StartProcessDtoSource.Schedule;
            }
            return null;
        }
    }
}
