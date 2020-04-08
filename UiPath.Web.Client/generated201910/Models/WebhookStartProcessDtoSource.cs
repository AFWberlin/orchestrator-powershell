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
    /// Defines values for WebhookStartProcessDtoSource.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookStartProcessDtoSource
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Schedule")]
        Schedule,
        [EnumMember(Value = "Queue")]
        Queue
    }
    internal static class WebhookStartProcessDtoSourceEnumExtension
    {
        internal static string ToSerializedValue(this WebhookStartProcessDtoSource? value)
        {
            return value == null ? null : ((WebhookStartProcessDtoSource)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookStartProcessDtoSource value)
        {
            switch( value )
            {
                case WebhookStartProcessDtoSource.Manual:
                    return "Manual";
                case WebhookStartProcessDtoSource.Schedule:
                    return "Schedule";
                case WebhookStartProcessDtoSource.Queue:
                    return "Queue";
            }
            return null;
        }

        internal static WebhookStartProcessDtoSource? ParseWebhookStartProcessDtoSource(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return WebhookStartProcessDtoSource.Manual;
                case "Schedule":
                    return WebhookStartProcessDtoSource.Schedule;
                case "Queue":
                    return WebhookStartProcessDtoSource.Queue;
            }
            return null;
        }
    }
}
