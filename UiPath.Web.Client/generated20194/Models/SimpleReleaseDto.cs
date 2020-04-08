// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Entity derived from ReleaseDto. It shares all the properties of the
    /// base entity except the navigation properties.
    /// </summary>
    public partial class SimpleReleaseDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleReleaseDto class.
        /// </summary>
        public SimpleReleaseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleReleaseDto class.
        /// </summary>
        /// <param name="processKey">The unique identifier of the process
        /// associated with the release.</param>
        /// <param name="processVersion">The version of the process associated
        /// with the release.</param>
        /// <param name="name">A custom name of the release. The default name
        /// format is ProcessName_EnvironmentName.</param>
        /// <param name="environmentId">The Id of the environment associated
        /// with the release.</param>
        /// <param name="key">A unique identifier associated to each
        /// release.</param>
        /// <param name="isLatestVersion">States whether the version of process
        /// associated with the release is latest or not.</param>
        /// <param name="isProcessDeleted">States whether the process
        /// associated with the release is deleted or not.</param>
        /// <param name="description">Used to add additional information about
        /// a release in order to better identify it.</param>
        /// <param name="environmentName">The name of the environment
        /// associated with the release.</param>
        /// <param name="environment">The environment associated with the
        /// release.</param>
        /// <param name="inputArguments">Input parameters in JSON format to be
        /// passed as default values to job execution.</param>
        /// <param name="currentVersion">The release version associated with
        /// the current release.</param>
        /// <param name="releaseVersions">The collection of release versions
        /// that current release had over time.</param>
        /// <param name="arguments">Input/Output arguments consumed/produced by
        /// the release</param>
        public SimpleReleaseDto(string processKey, string processVersion, string name, long environmentId, string key = default(string), bool? isLatestVersion = default(bool?), bool? isProcessDeleted = default(bool?), string description = default(string), string environmentName = default(string), EnvironmentDto environment = default(EnvironmentDto), string inputArguments = default(string), ReleaseVersionDto currentVersion = default(ReleaseVersionDto), IList<ReleaseVersionDto> releaseVersions = default(IList<ReleaseVersionDto>), ArgumentMetadata arguments = default(ArgumentMetadata), ProcessSettingsDto processSettings = default(ProcessSettingsDto), long? id = default(long?))
        {
            Key = key;
            ProcessKey = processKey;
            ProcessVersion = processVersion;
            IsLatestVersion = isLatestVersion;
            IsProcessDeleted = isProcessDeleted;
            Description = description;
            Name = name;
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
            Environment = environment;
            InputArguments = inputArguments;
            CurrentVersion = currentVersion;
            ReleaseVersions = releaseVersions;
            Arguments = arguments;
            ProcessSettings = processSettings;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a unique identifier associated to each release.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the process associated with
        /// the release.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessKey")]
        public string ProcessKey { get; set; }

        /// <summary>
        /// Gets or sets the version of the process associated with the
        /// release.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessVersion")]
        public string ProcessVersion { get; set; }

        /// <summary>
        /// Gets or sets states whether the version of process associated with
        /// the release is latest or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsLatestVersion")]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Gets or sets states whether the process associated with the release
        /// is deleted or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsProcessDeleted")]
        public bool? IsProcessDeleted { get; set; }

        /// <summary>
        /// Gets or sets used to add additional information about a release in
        /// order to better identify it.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a custom name of the release. The default name format
        /// is ProcessName_EnvironmentName.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Id of the environment associated with the release.
        /// </summary>
        [JsonProperty(PropertyName = "EnvironmentId")]
        public long EnvironmentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the environment associated with the
        /// release.
        /// </summary>
        [JsonProperty(PropertyName = "EnvironmentName")]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Gets or sets the environment associated with the release.
        /// </summary>
        [JsonProperty(PropertyName = "Environment")]
        public EnvironmentDto Environment { get; set; }

        /// <summary>
        /// Gets or sets input parameters in JSON format to be passed as
        /// default values to job execution.
        /// </summary>
        [JsonProperty(PropertyName = "InputArguments")]
        public string InputArguments { get; set; }

        /// <summary>
        /// Gets or sets the release version associated with the current
        /// release.
        /// </summary>
        [JsonProperty(PropertyName = "CurrentVersion")]
        public ReleaseVersionDto CurrentVersion { get; set; }

        /// <summary>
        /// Gets or sets the collection of release versions that current
        /// release had over time.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseVersions")]
        public IList<ReleaseVersionDto> ReleaseVersions { get; set; }

        /// <summary>
        /// Gets or sets input/Output arguments consumed/produced by the
        /// release
        /// </summary>
        [JsonProperty(PropertyName = "Arguments")]
        public ArgumentMetadata Arguments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProcessSettings")]
        public ProcessSettingsDto ProcessSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProcessKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessKey");
            }
            if (ProcessVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessVersion");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Environment != null)
            {
                Environment.Validate();
            }
            if (CurrentVersion != null)
            {
                CurrentVersion.Validate();
            }
            if (ReleaseVersions != null)
            {
                foreach (var element in ReleaseVersions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
