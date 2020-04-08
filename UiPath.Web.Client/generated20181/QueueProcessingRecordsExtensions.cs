// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueueProcessingRecords.
    /// </summary>
    public static partial class QueueProcessingRecordsExtensions
    {
            /// <summary>
            /// Returns the EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            public static object GetQueueProcessingRecords(this IQueueProcessingRecords operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetQueueProcessingRecordsAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetQueueProcessingRecordsAsync(this IQueueProcessingRecords operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQueueProcessingRecordsWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Post a new entity to EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueProcessingRecordDto'>
            /// The entity to post
            /// </param>
            public static object Post(this IQueueProcessingRecords operations, QueueProcessingRecordDto queueProcessingRecordDto)
            {
                return operations.PostAsync(queueProcessingRecordDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a new entity to EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueProcessingRecordDto'>
            /// The entity to post
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostAsync(this IQueueProcessingRecords operations, QueueProcessingRecordDto queueProcessingRecordDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(queueProcessingRecordDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the entity with the key from QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            public static object GetById(this IQueueProcessingRecords operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the entity with the key from QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByIdAsync(this IQueueProcessingRecords operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete entity in EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            public static object DeleteById(this IQueueProcessingRecords operations, long id, string ifMatch = default(string))
            {
                return operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity in EntitySet QueueProcessingRecords
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteByIdAsync(this IQueueProcessingRecords operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the computed processing status for a given queue in the last
            /// specified days.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='daysNo'>
            /// The number of days to go back from the present moment when calculating the
            /// report. If it is 0 the report will be computed for the last hour.
            /// </param>
            /// <param name='queueDefinitionId'>
            /// The Id of the queue for which the report is computed.
            /// </param>
            public static ODataResponseListQueueProcessingRecordDto RetrieveLastDaysProcessingRecordsByDaysnoAndQueuedefinitionid(this IQueueProcessingRecords operations, int daysNo, long queueDefinitionId)
            {
                return operations.RetrieveLastDaysProcessingRecordsByDaysnoAndQueuedefinitionidAsync(daysNo, queueDefinitionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the computed processing status for a given queue in the last
            /// specified days.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='daysNo'>
            /// The number of days to go back from the present moment when calculating the
            /// report. If it is 0 the report will be computed for the last hour.
            /// </param>
            /// <param name='queueDefinitionId'>
            /// The Id of the queue for which the report is computed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListQueueProcessingRecordDto> RetrieveLastDaysProcessingRecordsByDaysnoAndQueuedefinitionidAsync(this IQueueProcessingRecords operations, int daysNo, long queueDefinitionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RetrieveLastDaysProcessingRecordsByDaysnoAndQueuedefinitionidWithHttpMessagesAsync(daysNo, queueDefinitionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the processing status for all queues. Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ODataResponseListQueueProcessingStatus RetrieveQueuesProcessingStatus(this IQueueProcessingRecords operations)
            {
                return operations.RetrieveQueuesProcessingStatusAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the processing status for all queues. Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListQueueProcessingStatus> RetrieveQueuesProcessingStatusAsync(this IQueueProcessingRecords operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RetrieveQueuesProcessingStatusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
