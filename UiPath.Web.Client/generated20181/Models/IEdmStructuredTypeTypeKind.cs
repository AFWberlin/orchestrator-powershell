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
    /// Defines values for IEdmStructuredTypeTypeKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmStructuredTypeTypeKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Primitive")]
        Primitive,
        [EnumMember(Value = "Entity")]
        Entity,
        [EnumMember(Value = "Complex")]
        Complex,
        [EnumMember(Value = "Collection")]
        Collection,
        [EnumMember(Value = "EntityReference")]
        EntityReference,
        [EnumMember(Value = "Enum")]
        Enum,
        [EnumMember(Value = "TypeDefinition")]
        TypeDefinition,
        [EnumMember(Value = "Untyped")]
        Untyped
    }
    internal static class IEdmStructuredTypeTypeKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmStructuredTypeTypeKind? value)
        {
            return value == null ? null : ((IEdmStructuredTypeTypeKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmStructuredTypeTypeKind value)
        {
            switch( value )
            {
                case IEdmStructuredTypeTypeKind.None:
                    return "None";
                case IEdmStructuredTypeTypeKind.Primitive:
                    return "Primitive";
                case IEdmStructuredTypeTypeKind.Entity:
                    return "Entity";
                case IEdmStructuredTypeTypeKind.Complex:
                    return "Complex";
                case IEdmStructuredTypeTypeKind.Collection:
                    return "Collection";
                case IEdmStructuredTypeTypeKind.EntityReference:
                    return "EntityReference";
                case IEdmStructuredTypeTypeKind.Enum:
                    return "Enum";
                case IEdmStructuredTypeTypeKind.TypeDefinition:
                    return "TypeDefinition";
                case IEdmStructuredTypeTypeKind.Untyped:
                    return "Untyped";
            }
            return null;
        }

        internal static IEdmStructuredTypeTypeKind? ParseIEdmStructuredTypeTypeKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmStructuredTypeTypeKind.None;
                case "Primitive":
                    return IEdmStructuredTypeTypeKind.Primitive;
                case "Entity":
                    return IEdmStructuredTypeTypeKind.Entity;
                case "Complex":
                    return IEdmStructuredTypeTypeKind.Complex;
                case "Collection":
                    return IEdmStructuredTypeTypeKind.Collection;
                case "EntityReference":
                    return IEdmStructuredTypeTypeKind.EntityReference;
                case "Enum":
                    return IEdmStructuredTypeTypeKind.Enum;
                case "TypeDefinition":
                    return IEdmStructuredTypeTypeKind.TypeDefinition;
                case "Untyped":
                    return IEdmStructuredTypeTypeKind.Untyped;
            }
            return null;
        }
    }
}
