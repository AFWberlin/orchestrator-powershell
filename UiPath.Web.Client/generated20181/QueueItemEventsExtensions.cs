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
    /// Extension methods for QueueItemEvents.
    /// </summary>
    public static partial class QueueItemEventsExtensions
    {
            /// <summary>
            /// Gets the QueueItemEvents.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
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
            public static ODataResponseListQueueItemEventDto GetQueueItemEvents(this IQueueItemEvents operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetQueueItemEventsAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the QueueItemEvents.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
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
            public static async Task<ODataResponseListQueueItemEventDto> GetQueueItemEventsAsync(this IQueueItemEvents operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQueueItemEventsWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a QueueItemEvent by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
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
            public static QueueItemEventDto GetById(this IQueueItemEvents operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a QueueItemEvent by Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
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
            public static async Task<QueueItemEventDto> GetByIdAsync(this IQueueItemEvents operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a collection of Queue Item Events associated to a Queue Item and
            /// all its related Queue Items.
            /// A Queue Item is related to another if it was created as a retry of a failed
            /// Queue Item. They also share the same Key.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemId'>
            /// The Id of the Queue Item for which the event history is requested.
            /// </param>
            public static ODataResponseListQueueItemEventDto GetQueueItemEventsHistoryByQueueitemid(this IQueueItemEvents operations, long queueItemId)
            {
                return operations.GetQueueItemEventsHistoryByQueueitemidAsync(queueItemId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of Queue Item Events associated to a Queue Item and
            /// all its related Queue Items.
            /// A Queue Item is related to another if it was created as a retry of a failed
            /// Queue Item. They also share the same Key.
            /// </summary>
            /// <remarks>
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemId'>
            /// The Id of the Queue Item for which the event history is requested.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListQueueItemEventDto> GetQueueItemEventsHistoryByQueueitemidAsync(this IQueueItemEvents operations, long queueItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQueueItemEventsHistoryByQueueitemidWithHttpMessagesAsync(queueItemId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
