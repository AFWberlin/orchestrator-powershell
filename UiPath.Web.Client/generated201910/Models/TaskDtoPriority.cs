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
    /// Defines values for TaskDtoPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskDtoPriority
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
    internal static class TaskDtoPriorityEnumExtension
    {
        internal static string ToSerializedValue(this TaskDtoPriority? value)
        {
            return value == null ? null : ((TaskDtoPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskDtoPriority value)
        {
            switch( value )
            {
                case TaskDtoPriority.Low:
                    return "Low";
                case TaskDtoPriority.Medium:
                    return "Medium";
                case TaskDtoPriority.High:
                    return "High";
                case TaskDtoPriority.Critical:
                    return "Critical";
            }
            return null;
        }

        internal static TaskDtoPriority? ParseTaskDtoPriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return TaskDtoPriority.Low;
                case "Medium":
                    return TaskDtoPriority.Medium;
                case "High":
                    return TaskDtoPriority.High;
                case "Critical":
                    return TaskDtoPriority.Critical;
            }
            return null;
        }
    }
}
