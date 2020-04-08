// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Stores data sent when processing an item ended.
    /// </summary>
    public partial class TransactionResultDto
    {
        /// <summary>
        /// Initializes a new instance of the TransactionResultDto class.
        /// </summary>
        public TransactionResultDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionResultDto class.
        /// </summary>
        /// <param name="isSuccessful">States if the processing was successful
        /// or not.</param>
        /// <param name="processingException">The details of the processing
        /// exception thrown if the item failed.</param>
        /// <param name="deferDate">The earliest date and time at which the
        /// item is available for processing. If empty the item can be
        /// processed as soon as possible.</param>
        /// <param name="dueDate">The latest date and time at which the item
        /// should be processed. If empty the item can be processed at any
        /// given time.</param>
        /// <param name="output">A collection of key value pairs containing
        /// custom data resulted after successful processing.</param>
        /// <param name="analytics">A collection of key value pairs containing
        /// custom data for further analytics processing.</param>
        /// <param name="progress">String field which is used to keep track of
        /// the business flow progress.</param>
        public TransactionResultDto(bool? isSuccessful = default(bool?), ProcessingExceptionDto processingException = default(ProcessingExceptionDto), System.DateTime? deferDate = default(System.DateTime?), System.DateTime? dueDate = default(System.DateTime?), IDictionary<string, object> output = default(IDictionary<string, object>), IDictionary<string, object> analytics = default(IDictionary<string, object>), string progress = default(string))
        {
            IsSuccessful = isSuccessful;
            ProcessingException = processingException;
            DeferDate = deferDate;
            DueDate = dueDate;
            Output = output;
            Analytics = analytics;
            Progress = progress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets states if the processing was successful or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsSuccessful")]
        public bool? IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the details of the processing exception thrown if the
        /// item failed.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessingException")]
        public ProcessingExceptionDto ProcessingException { get; set; }

        /// <summary>
        /// Gets or sets the earliest date and time at which the item is
        /// available for processing. If empty the item can be processed as
        /// soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "DeferDate")]
        public System.DateTime? DeferDate { get; set; }

        /// <summary>
        /// Gets or sets the latest date and time at which the item should be
        /// processed. If empty the item can be processed at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// resulted after successful processing.
        /// </summary>
        [JsonProperty(PropertyName = "Output")]
        public IDictionary<string, object> Output { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// for further analytics processing.
        /// </summary>
        [JsonProperty(PropertyName = "Analytics")]
        public IDictionary<string, object> Analytics { get; set; }

        /// <summary>
        /// Gets or sets string field which is used to keep track of the
        /// business flow progress.
        /// </summary>
        [JsonProperty(PropertyName = "Progress")]
        public string Progress { get; set; }

    }
}
