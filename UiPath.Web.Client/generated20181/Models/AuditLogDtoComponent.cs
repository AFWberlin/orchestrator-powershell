// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuditLogDtoComponent.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditLogDtoComponent
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Assets")]
        Assets,
        [EnumMember(Value = "Environments")]
        Environments,
        [EnumMember(Value = "Processes")]
        Processes,
        [EnumMember(Value = "Queues")]
        Queues,
        [EnumMember(Value = "Robots")]
        Robots,
        [EnumMember(Value = "Roles")]
        Roles,
        [EnumMember(Value = "Schedules")]
        Schedules,
        [EnumMember(Value = "Users")]
        Users,
        [EnumMember(Value = "Comments")]
        Comments,
        [EnumMember(Value = "Units")]
        Units,
        [EnumMember(Value = "Jobs")]
        Jobs,
        [EnumMember(Value = "Settings")]
        Settings,
        [EnumMember(Value = "Packages")]
        Packages,
        [EnumMember(Value = "License")]
        License,
        [EnumMember(Value = "Tenant")]
        Tenant
    }
    internal static class AuditLogDtoComponentEnumExtension
    {
        internal static string ToSerializedValue(this AuditLogDtoComponent? value)
        {
            return value == null ? null : ((AuditLogDtoComponent)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuditLogDtoComponent value)
        {
            switch( value )
            {
                case AuditLogDtoComponent.Unknown:
                    return "Unknown";
                case AuditLogDtoComponent.Assets:
                    return "Assets";
                case AuditLogDtoComponent.Environments:
                    return "Environments";
                case AuditLogDtoComponent.Processes:
                    return "Processes";
                case AuditLogDtoComponent.Queues:
                    return "Queues";
                case AuditLogDtoComponent.Robots:
                    return "Robots";
                case AuditLogDtoComponent.Roles:
                    return "Roles";
                case AuditLogDtoComponent.Schedules:
                    return "Schedules";
                case AuditLogDtoComponent.Users:
                    return "Users";
                case AuditLogDtoComponent.Comments:
                    return "Comments";
                case AuditLogDtoComponent.Units:
                    return "Units";
                case AuditLogDtoComponent.Jobs:
                    return "Jobs";
                case AuditLogDtoComponent.Settings:
                    return "Settings";
                case AuditLogDtoComponent.Packages:
                    return "Packages";
                case AuditLogDtoComponent.License:
                    return "License";
                case AuditLogDtoComponent.Tenant:
                    return "Tenant";
            }
            return null;
        }

        internal static AuditLogDtoComponent? ParseAuditLogDtoComponent(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return AuditLogDtoComponent.Unknown;
                case "Assets":
                    return AuditLogDtoComponent.Assets;
                case "Environments":
                    return AuditLogDtoComponent.Environments;
                case "Processes":
                    return AuditLogDtoComponent.Processes;
                case "Queues":
                    return AuditLogDtoComponent.Queues;
                case "Robots":
                    return AuditLogDtoComponent.Robots;
                case "Roles":
                    return AuditLogDtoComponent.Roles;
                case "Schedules":
                    return AuditLogDtoComponent.Schedules;
                case "Users":
                    return AuditLogDtoComponent.Users;
                case "Comments":
                    return AuditLogDtoComponent.Comments;
                case "Units":
                    return AuditLogDtoComponent.Units;
                case "Jobs":
                    return AuditLogDtoComponent.Jobs;
                case "Settings":
                    return AuditLogDtoComponent.Settings;
                case "Packages":
                    return AuditLogDtoComponent.Packages;
                case "License":
                    return AuditLogDtoComponent.License;
                case "Tenant":
                    return AuditLogDtoComponent.Tenant;
            }
            return null;
        }
    }
}
