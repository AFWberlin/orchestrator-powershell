// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SmtpParameters
    {
        /// <summary>
        /// Initializes a new instance of the SmtpParameters class.
        /// </summary>
        public SmtpParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmtpParameters class.
        /// </summary>
        public SmtpParameters(string sendTo = default(string), SmtpSettingModel smtpSettingModel = default(SmtpSettingModel))
        {
            SendTo = sendTo;
            SmtpSettingModel = smtpSettingModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendTo")]
        public string SendTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "smtpSettingModel")]
        public SmtpSettingModel SmtpSettingModel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SmtpSettingModel != null)
            {
                SmtpSettingModel.Validate();
            }
        }
    }
}
