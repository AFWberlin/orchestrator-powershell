// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A process is a project defined in UiPath Studio and published in
    /// Orchestrator from UiPath Studio or manually.
    /// </summary>
    public partial class ProcessDto
    {
        /// <summary>
        /// Initializes a new instance of the ProcessDto class.
        /// </summary>
        public ProcessDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessDto class.
        /// </summary>
        /// <param name="isActive">Specifies if the process is still
        /// active.</param>
        /// <param name="arguments">Input/Output arguments supported by the
        /// process</param>
        /// <param name="title">The custom name of the package.</param>
        /// <param name="version">The current version of the given
        /// package.</param>
        /// <param name="key">The unique identifier for the package.</param>
        /// <param name="description">Used to add additional information about
        /// a package in order to better identify it.</param>
        /// <param name="published">The date and time when the package was
        /// published or uploaded.</param>
        /// <param name="isLatestVersion">Specifies whether the current version
        /// is the latest of the given package.</param>
        /// <param name="oldVersion">Specifies the last version before the
        /// current one.</param>
        /// <param name="releaseNotes">Package release notes.</param>
        /// <param name="authors">Package authors.</param>
        public ProcessDto(bool? isActive = default(bool?), ArgumentMetadata arguments = default(ArgumentMetadata), string title = default(string), string version = default(string), string key = default(string), string description = default(string), System.DateTime? published = default(System.DateTime?), bool? isLatestVersion = default(bool?), string oldVersion = default(string), string releaseNotes = default(string), string authors = default(string), string id = default(string))
        {
            IsActive = isActive;
            Arguments = arguments;
            Title = title;
            Version = version;
            Key = key;
            Description = description;
            Published = published;
            IsLatestVersion = isLatestVersion;
            OldVersion = oldVersion;
            ReleaseNotes = releaseNotes;
            Authors = authors;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies if the process is still active.
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets input/Output arguments supported by the process
        /// </summary>
        [JsonProperty(PropertyName = "Arguments")]
        public ArgumentMetadata Arguments { get; set; }

        /// <summary>
        /// Gets or sets the custom name of the package.
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the current version of the given package.
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the package.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets used to add additional information about a package in
        /// order to better identify it.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the package was published or
        /// uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "Published")]
        public System.DateTime? Published { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the current version is the latest of
        /// the given package.
        /// </summary>
        [JsonProperty(PropertyName = "IsLatestVersion")]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Gets or sets specifies the last version before the current one.
        /// </summary>
        [JsonProperty(PropertyName = "OldVersion")]
        public string OldVersion { get; set; }

        /// <summary>
        /// Gets or sets package release notes.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseNotes")]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or sets package authors.
        /// </summary>
        [JsonProperty(PropertyName = "Authors")]
        public string Authors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

    }
}
