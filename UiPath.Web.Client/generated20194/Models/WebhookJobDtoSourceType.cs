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
    /// Defines values for WebhookJobDtoSourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookJobDtoSourceType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Schedule")]
        Schedule,
        [EnumMember(Value = "Agent")]
        Agent
    }
    internal static class WebhookJobDtoSourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookJobDtoSourceType? value)
        {
            return value == null ? null : ((WebhookJobDtoSourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookJobDtoSourceType value)
        {
            switch( value )
            {
                case WebhookJobDtoSourceType.Manual:
                    return "Manual";
                case WebhookJobDtoSourceType.Schedule:
                    return "Schedule";
                case WebhookJobDtoSourceType.Agent:
                    return "Agent";
            }
            return null;
        }

        internal static WebhookJobDtoSourceType? ParseWebhookJobDtoSourceType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return WebhookJobDtoSourceType.Manual;
                case "Schedule":
                    return WebhookJobDtoSourceType.Schedule;
                case "Agent":
                    return WebhookJobDtoSourceType.Agent;
            }
            return null;
        }
    }
}
