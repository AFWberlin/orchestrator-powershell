// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CredentialStoreResourceDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CredentialStoreResourceDtoType
    {
        [EnumMember(Value = "AssetCredential")]
        AssetCredential,
        [EnumMember(Value = "RobotCredential")]
        RobotCredential,
        [EnumMember(Value = "BucketCredential")]
        BucketCredential
    }
    internal static class CredentialStoreResourceDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this CredentialStoreResourceDtoType? value)
        {
            return value == null ? null : ((CredentialStoreResourceDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CredentialStoreResourceDtoType value)
        {
            switch( value )
            {
                case CredentialStoreResourceDtoType.AssetCredential:
                    return "AssetCredential";
                case CredentialStoreResourceDtoType.RobotCredential:
                    return "RobotCredential";
                case CredentialStoreResourceDtoType.BucketCredential:
                    return "BucketCredential";
            }
            return null;
        }

        internal static CredentialStoreResourceDtoType? ParseCredentialStoreResourceDtoType(this string value)
        {
            switch( value )
            {
                case "AssetCredential":
                    return CredentialStoreResourceDtoType.AssetCredential;
                case "RobotCredential":
                    return CredentialStoreResourceDtoType.RobotCredential;
                case "BucketCredential":
                    return CredentialStoreResourceDtoType.BucketCredential;
            }
            return null;
        }
    }
}