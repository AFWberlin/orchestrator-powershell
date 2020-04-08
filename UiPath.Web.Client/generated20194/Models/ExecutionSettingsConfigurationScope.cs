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
    /// Defines values for ExecutionSettingsConfigurationScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExecutionSettingsConfigurationScope
    {
        [EnumMember(Value = "Global")]
        Global,
        [EnumMember(Value = "Robot")]
        Robot
    }
    internal static class ExecutionSettingsConfigurationScopeEnumExtension
    {
        internal static string ToSerializedValue(this ExecutionSettingsConfigurationScope? value)
        {
            return value == null ? null : ((ExecutionSettingsConfigurationScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ExecutionSettingsConfigurationScope value)
        {
            switch( value )
            {
                case ExecutionSettingsConfigurationScope.Global:
                    return "Global";
                case ExecutionSettingsConfigurationScope.Robot:
                    return "Robot";
            }
            return null;
        }

        internal static ExecutionSettingsConfigurationScope? ParseExecutionSettingsConfigurationScope(this string value)
        {
            switch( value )
            {
                case "Global":
                    return ExecutionSettingsConfigurationScope.Global;
                case "Robot":
                    return ExecutionSettingsConfigurationScope.Robot;
            }
            return null;
        }
    }
}
