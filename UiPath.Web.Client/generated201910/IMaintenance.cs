// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Maintenance operations.
    /// </summary>
    public partial interface IMaintenance
    {
        /// <summary>
        /// Gets the host admin logs.
        /// </summary>
        /// <remarks>
        /// Host only. Required permissions: Audit.View.
        /// </remarks>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<MaintenanceSetting>> GetWithHttpMessagesAsync(int? tenantId = default(int?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Starts a maintenance window
        /// </summary>
        /// <remarks>
        /// Host only. Requires authentication.
        /// </remarks>
        /// <param name='phase'>
        /// Phase - {UiPath.Orchestrator.Core.Enums.MaintenanceState.Draining}
        /// or {UiPath.Orchestrator.Core.Enums.MaintenanceState.Suspended}.
        /// Possible values include: 'None', 'Draining', 'Suspended'
        /// </param>
        /// <param name='force'>
        /// Whether to ignore errors during transition
        /// </param>
        /// <param name='killJobs'>
        /// Whether to force-kill running jobs when transitioning to
        /// {UiPath.Orchestrator.Core.Enums.MaintenanceState.Suspended}
        /// </param>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> StartWithHttpMessagesAsync(string phase, bool? force = default(bool?), bool? killJobs = default(bool?), int? tenantId = default(int?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Ends a maintenance window
        /// </summary>
        /// <remarks>
        /// Host only. Requires authentication.
        /// </remarks>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> EndWithHttpMessagesAsync(int? tenantId = default(int?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
