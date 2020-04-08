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
    /// Defines values for WebhookSessionDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSessionDtoState
    {
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Busy")]
        Busy,
        [EnumMember(Value = "Disconnected")]
        Disconnected,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class WebhookSessionDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this WebhookSessionDtoState? value)
        {
            return value == null ? null : ((WebhookSessionDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookSessionDtoState value)
        {
            switch( value )
            {
                case WebhookSessionDtoState.Available:
                    return "Available";
                case WebhookSessionDtoState.Busy:
                    return "Busy";
                case WebhookSessionDtoState.Disconnected:
                    return "Disconnected";
                case WebhookSessionDtoState.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static WebhookSessionDtoState? ParseWebhookSessionDtoState(this string value)
        {
            switch( value )
            {
                case "Available":
                    return WebhookSessionDtoState.Available;
                case "Busy":
                    return WebhookSessionDtoState.Busy;
                case "Disconnected":
                    return WebhookSessionDtoState.Disconnected;
                case "Unknown":
                    return WebhookSessionDtoState.Unknown;
            }
            return null;
        }
    }
}
