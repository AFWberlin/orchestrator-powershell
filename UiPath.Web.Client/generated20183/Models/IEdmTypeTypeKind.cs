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
    /// Defines values for IEdmTypeTypeKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmTypeTypeKind
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
        Untyped,
        [EnumMember(Value = "Path")]
        Path
    }
    internal static class IEdmTypeTypeKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmTypeTypeKind? value)
        {
            return value == null ? null : ((IEdmTypeTypeKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmTypeTypeKind value)
        {
            switch( value )
            {
                case IEdmTypeTypeKind.None:
                    return "None";
                case IEdmTypeTypeKind.Primitive:
                    return "Primitive";
                case IEdmTypeTypeKind.Entity:
                    return "Entity";
                case IEdmTypeTypeKind.Complex:
                    return "Complex";
                case IEdmTypeTypeKind.Collection:
                    return "Collection";
                case IEdmTypeTypeKind.EntityReference:
                    return "EntityReference";
                case IEdmTypeTypeKind.Enum:
                    return "Enum";
                case IEdmTypeTypeKind.TypeDefinition:
                    return "TypeDefinition";
                case IEdmTypeTypeKind.Untyped:
                    return "Untyped";
                case IEdmTypeTypeKind.Path:
                    return "Path";
            }
            return null;
        }

        internal static IEdmTypeTypeKind? ParseIEdmTypeTypeKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmTypeTypeKind.None;
                case "Primitive":
                    return IEdmTypeTypeKind.Primitive;
                case "Entity":
                    return IEdmTypeTypeKind.Entity;
                case "Complex":
                    return IEdmTypeTypeKind.Complex;
                case "Collection":
                    return IEdmTypeTypeKind.Collection;
                case "EntityReference":
                    return IEdmTypeTypeKind.EntityReference;
                case "Enum":
                    return IEdmTypeTypeKind.Enum;
                case "TypeDefinition":
                    return IEdmTypeTypeKind.TypeDefinition;
                case "Untyped":
                    return IEdmTypeTypeKind.Untyped;
                case "Path":
                    return IEdmTypeTypeKind.Path;
            }
            return null;
        }
    }
}
