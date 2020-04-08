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
    /// Defines values for WebhookTaskAssignmentChangedDtoPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTaskAssignmentChangedDtoPriority
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
    internal static class WebhookTaskAssignmentChangedDtoPriorityEnumExtension
    {
        internal static string ToSerializedValue(this WebhookTaskAssignmentChangedDtoPriority? value)
        {
            return value == null ? null : ((WebhookTaskAssignmentChangedDtoPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookTaskAssignmentChangedDtoPriority value)
        {
            switch( value )
            {
                case WebhookTaskAssignmentChangedDtoPriority.Low:
                    return "Low";
                case WebhookTaskAssignmentChangedDtoPriority.Medium:
                    return "Medium";
                case WebhookTaskAssignmentChangedDtoPriority.High:
                    return "High";
                case WebhookTaskAssignmentChangedDtoPriority.Critical:
                    return "Critical";
            }
            return null;
        }

        internal static WebhookTaskAssignmentChangedDtoPriority? ParseWebhookTaskAssignmentChangedDtoPriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return WebhookTaskAssignmentChangedDtoPriority.Low;
                case "Medium":
                    return WebhookTaskAssignmentChangedDtoPriority.Medium;
                case "High":
                    return WebhookTaskAssignmentChangedDtoPriority.High;
                case "Critical":
                    return WebhookTaskAssignmentChangedDtoPriority.Critical;
            }
            return null;
        }
    }
}
