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
    /// Defines values for AssetDtoValueScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetDtoValueScope
    {
        [EnumMember(Value = "Global")]
        Global,
        [EnumMember(Value = "PerRobot")]
        PerRobot
    }
    internal static class AssetDtoValueScopeEnumExtension
    {
        internal static string ToSerializedValue(this AssetDtoValueScope? value)
        {
            return value == null ? null : ((AssetDtoValueScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AssetDtoValueScope value)
        {
            switch( value )
            {
                case AssetDtoValueScope.Global:
                    return "Global";
                case AssetDtoValueScope.PerRobot:
                    return "PerRobot";
            }
            return null;
        }

        internal static AssetDtoValueScope? ParseAssetDtoValueScope(this string value)
        {
            switch( value )
            {
                case "Global":
                    return AssetDtoValueScope.Global;
                case "PerRobot":
                    return AssetDtoValueScope.PerRobot;
            }
            return null;
        }
    }
}
