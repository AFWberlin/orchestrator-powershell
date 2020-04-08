// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookProcessingExceptionDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookProcessingExceptionDtoType
    {
        [EnumMember(Value = "ApplicationException")]
        ApplicationException,
        [EnumMember(Value = "BusinessException")]
        BusinessException
    }
    internal static class WebhookProcessingExceptionDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookProcessingExceptionDtoType? value)
        {
            return value == null ? null : ((WebhookProcessingExceptionDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookProcessingExceptionDtoType value)
        {
            switch( value )
            {
                case WebhookProcessingExceptionDtoType.ApplicationException:
                    return "ApplicationException";
                case WebhookProcessingExceptionDtoType.BusinessException:
                    return "BusinessException";
            }
            return null;
        }

        internal static WebhookProcessingExceptionDtoType? ParseWebhookProcessingExceptionDtoType(this string value)
        {
            switch( value )
            {
                case "ApplicationException":
                    return WebhookProcessingExceptionDtoType.ApplicationException;
                case "BusinessException":
                    return WebhookProcessingExceptionDtoType.BusinessException;
            }
            return null;
        }
    }
}
