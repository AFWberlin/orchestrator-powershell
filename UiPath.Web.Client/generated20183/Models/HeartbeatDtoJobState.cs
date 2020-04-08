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
    /// Defines values for HeartbeatDtoJobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeartbeatDtoJobState
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopping")]
        Stopping,
        [EnumMember(Value = "Terminating")]
        Terminating,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Stopped")]
        Stopped
    }
    internal static class HeartbeatDtoJobStateEnumExtension
    {
        internal static string ToSerializedValue(this HeartbeatDtoJobState? value)
        {
            return value == null ? null : ((HeartbeatDtoJobState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this HeartbeatDtoJobState value)
        {
            switch( value )
            {
                case HeartbeatDtoJobState.Pending:
                    return "Pending";
                case HeartbeatDtoJobState.Running:
                    return "Running";
                case HeartbeatDtoJobState.Stopping:
                    return "Stopping";
                case HeartbeatDtoJobState.Terminating:
                    return "Terminating";
                case HeartbeatDtoJobState.Faulted:
                    return "Faulted";
                case HeartbeatDtoJobState.Successful:
                    return "Successful";
                case HeartbeatDtoJobState.Stopped:
                    return "Stopped";
            }
            return null;
        }

        internal static HeartbeatDtoJobState? ParseHeartbeatDtoJobState(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return HeartbeatDtoJobState.Pending;
                case "Running":
                    return HeartbeatDtoJobState.Running;
                case "Stopping":
                    return HeartbeatDtoJobState.Stopping;
                case "Terminating":
                    return HeartbeatDtoJobState.Terminating;
                case "Faulted":
                    return HeartbeatDtoJobState.Faulted;
                case "Successful":
                    return HeartbeatDtoJobState.Successful;
                case "Stopped":
                    return HeartbeatDtoJobState.Stopped;
            }
            return null;
        }
    }
}
