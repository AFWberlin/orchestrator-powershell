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
    /// Defines values for WebhookTaskCompletedDtoPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTaskCompletedDtoPriority
    {
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Critical")]
        Critical
    }
    internal static class WebhookTaskCompletedDtoPriorityEnumExtension
    {
        internal static string ToSerializedValue(this WebhookTaskCompletedDtoPriority? value)
        {
            return value == null ? null : ((WebhookTaskCompletedDtoPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookTaskCompletedDtoPriority value)
        {
            switch( value )
            {
                case WebhookTaskCompletedDtoPriority.Low:
                    return "Low";
                case WebhookTaskCompletedDtoPriority.Medium:
                    return "Medium";
                case WebhookTaskCompletedDtoPriority.High:
                    return "High";
                case WebhookTaskCompletedDtoPriority.Critical:
                    return "Critical";
            }
            return null;
        }

        internal static WebhookTaskCompletedDtoPriority? ParseWebhookTaskCompletedDtoPriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return WebhookTaskCompletedDtoPriority.Low;
                case "Medium":
                    return WebhookTaskCompletedDtoPriority.Medium;
                case "High":
                    return WebhookTaskCompletedDtoPriority.High;
                case "Critical":
                    return WebhookTaskCompletedDtoPriority.Critical;
            }
            return null;
        }
    }
}
