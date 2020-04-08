// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Webhooks.
    /// </summary>
    public static partial class WebhooksExtensions
    {
            /// <summary>
            /// List webhooks
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
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
            public static ODataResponseListWebhookDto GetWebhooks(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetWebhooksAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List webhooks
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
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
            public static async Task<ODataResponseListWebhookDto> GetWebhooksAsync(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWebhooksWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to post
            /// </param>
            public static WebhookDto Post(this IWebhooks operations, WebhookDto webhookDto)
            {
                return operations.PostAsync(webhookDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to post
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PostAsync(this IWebhooks operations, WebhookDto webhookDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(webhookDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single webhook
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
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
            public static WebhookDto GetById(this IWebhooks operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single webhook
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
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
            public static async Task<WebhookDto> GetByIdAsync(this IWebhooks operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to put
            /// </param>
            public static WebhookDto PutById(this IWebhooks operations, long id, WebhookDto webhookDto)
            {
                return operations.PutByIdAsync(id, webhookDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PutByIdAsync(this IWebhooks operations, long id, WebhookDto webhookDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(id, webhookDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            public static void DeleteById(this IWebhooks operations, long id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a webhook subscription
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Delete.
            /// </remarks>
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
            public static async Task DeleteByIdAsync(this IWebhooks operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Patches a webhook
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to patch
            /// </param>
            public static WebhookDto PatchById(this IWebhooks operations, long id, WebhookDto webhookDto)
            {
                return operations.PatchByIdAsync(id, webhookDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches a webhook
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='webhookDto'>
            /// The entity to patch
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PatchByIdAsync(this IWebhooks operations, long id, WebhookDto webhookDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PatchByIdWithHttpMessagesAsync(id, webhookDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends a Ping request to webhook endpoint.
            /// Used for testing connectivity and availability of target URL
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            public static PingEventDto PingById(this IWebhooks operations, long id)
            {
                return operations.PingByIdAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends a Ping request to webhook endpoint.
            /// Used for testing connectivity and availability of target URL
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PingEventDto> PingByIdAsync(this IWebhooks operations, long id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PingByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of event types a webhook can subscribe to
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ODataResponseListWebhookEventTypeDto GetEventTypes(this IWebhooks operations)
            {
                return operations.GetEventTypesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of event types a webhook can subscribe to
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListWebhookEventTypeDto> GetEventTypesAsync(this IWebhooks operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetEventTypesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Triggers an event of type "custom"
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventData'>
            /// Any custom event data payload
            /// </param>
            public static CustomEventDto TriggerCustom(this IWebhooks operations, object eventData)
            {
                return operations.TriggerCustomAsync(eventData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers an event of type "custom"
            /// </summary>
            /// <remarks>
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventData'>
            /// Any custom event data payload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomEventDto> TriggerCustomAsync(this IWebhooks operations, object eventData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.TriggerCustomWithHttpMessagesAsync(eventData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
