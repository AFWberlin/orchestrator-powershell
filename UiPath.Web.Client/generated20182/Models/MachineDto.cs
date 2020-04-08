// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Machine that hosts the Robot
    /// </summary>
    public partial class MachineDto
    {
        /// <summary>
        /// Initializes a new instance of the MachineDto class.
        /// </summary>
        public MachineDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachineDto class.
        /// </summary>
        /// <param name="name">The name of the machine a Robot is hosted
        /// on.</param>
        /// <param name="licenseKey">The key is automatically generated from
        /// the server for the Robot machine.
        /// &lt;para /&gt;For the robot to work, the same key must exist on
        /// both the robot and Orchestrator.
        /// &lt;para /&gt;All robots on a machine must have the same license
        /// key in order to register correctly.</param>
        /// <param name="nonProductionSlots">Number of NonProduction slots to
        /// be reserved at runtime</param>
        /// <param name="unattendedSlots">Number of Unattended slots to be
        /// reserved at runtime</param>
        public MachineDto(string name, string licenseKey = default(string), int? nonProductionSlots = default(int?), int? unattendedSlots = default(int?), long? id = default(long?))
        {
            LicenseKey = licenseKey;
            Name = name;
            NonProductionSlots = nonProductionSlots;
            UnattendedSlots = unattendedSlots;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key is automatically generated from the server for
        /// the Robot machine.
        /// &amp;lt;para /&amp;gt;For the robot to work, the same key must
        /// exist on both the robot and Orchestrator.
        /// &amp;lt;para /&amp;gt;All robots on a machine must have the same
        /// license key in order to register correctly.
        /// </summary>
        [JsonProperty(PropertyName = "LicenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine a Robot is hosted on.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets number of NonProduction slots to be reserved at
        /// runtime
        /// </summary>
        [JsonProperty(PropertyName = "NonProductionSlots")]
        public int? NonProductionSlots { get; set; }

        /// <summary>
        /// Gets or sets number of Unattended slots to be reserved at runtime
        /// </summary>
        [JsonProperty(PropertyName = "UnattendedSlots")]
        public int? UnattendedSlots { get; set; }

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
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LicenseKey != null)
            {
                if (LicenseKey.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LicenseKey", 255);
                }
                if (LicenseKey.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "LicenseKey", 0);
                }
            }
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
        }
    }
}
