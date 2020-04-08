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
    /// Defines values for OrderByClauseDirection.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderByClauseDirection
    {
        [EnumMember(Value = "Ascending")]
        Ascending,
        [EnumMember(Value = "Descending")]
        Descending
    }
    internal static class OrderByClauseDirectionEnumExtension
    {
        internal static string ToSerializedValue(this OrderByClauseDirection? value)
        {
            return value == null ? null : ((OrderByClauseDirection)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OrderByClauseDirection value)
        {
            switch( value )
            {
                case OrderByClauseDirection.Ascending:
                    return "Ascending";
                case OrderByClauseDirection.Descending:
                    return "Descending";
            }
            return null;
        }

        internal static OrderByClauseDirection? ParseOrderByClauseDirection(this string value)
        {
            switch( value )
            {
                case "Ascending":
                    return OrderByClauseDirection.Ascending;
                case "Descending":
                    return OrderByClauseDirection.Descending;
            }
            return null;
        }
    }
}
