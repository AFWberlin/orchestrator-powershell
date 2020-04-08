// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Libraries.
    /// </summary>
    public static partial class LibrariesExtensions
    {
            /// <summary>
            /// Gets the library packages.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
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
            public static ODataResponseListLibraryDto GetLibraries(this ILibraries operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetLibrariesAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the library packages.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
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
            public static async Task<ODataResponseListLibraryDto> GetLibrariesAsync(this ILibraries operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetLibrariesWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a package.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.Delete.
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
            public static void DeleteById(this ILibraries operations, string id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a package.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.Delete.
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
            public static async Task DeleteByIdAsync(this ILibraries operations, string id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a collection of all available versions of a given package. Allows
            /// odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='packageId'>
            /// The Id of the package for which the versions are fetched.
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
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            public static ODataResponseListLibraryDto GetVersionsByPackageid(this ILibraries operations, string packageId, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetVersionsByPackageidAsync(packageId, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all available versions of a given package. Allows
            /// odata query options.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='packageId'>
            /// The Id of the package for which the versions are fetched.
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
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListLibraryDto> GetVersionsByPackageidAsync(this ILibraries operations, string packageId, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetVersionsByPackageidWithHttpMessagesAsync(packageId, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Downloads the .nupkg file of a Package.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static Stream DownloadPackageByKey(this ILibraries operations, string key)
            {
                return operations.DownloadPackageByKeyAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Downloads the .nupkg file of a Package.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> DownloadPackageByKeyAsync(this ILibraries operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var _result = await operations.DownloadPackageByKeyWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Uploads a new package or a new version of an existing package. The content
            /// of the package is sent as a .nupkg file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
            /// </param>
            /// <param name='file1'>
            /// </param>
            /// <param name='file2'>
            /// </param>
            /// <param name='file3'>
            /// </param>
            /// <param name='file4'>
            /// </param>
            /// <param name='file5'>
            /// </param>
            /// <param name='file6'>
            /// </param>
            /// <param name='file7'>
            /// </param>
            /// <param name='file8'>
            /// </param>
            /// <param name='file9'>
            /// </param>
            public static ODataResponseListBulkItemDtoString UploadPackage(this ILibraries operations, Stream file, Stream file1 = default(Stream), Stream file2 = default(Stream), Stream file3 = default(Stream), Stream file4 = default(Stream), Stream file5 = default(Stream), Stream file6 = default(Stream), Stream file7 = default(Stream), Stream file8 = default(Stream), Stream file9 = default(Stream))
            {
                return operations.UploadPackageAsync(file, file1, file2, file3, file4, file5, file6, file7, file8, file9).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads a new package or a new version of an existing package. The content
            /// of the package is sent as a .nupkg file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Required permissions: Libraries.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
            /// </param>
            /// <param name='file1'>
            /// </param>
            /// <param name='file2'>
            /// </param>
            /// <param name='file3'>
            /// </param>
            /// <param name='file4'>
            /// </param>
            /// <param name='file5'>
            /// </param>
            /// <param name='file6'>
            /// </param>
            /// <param name='file7'>
            /// </param>
            /// <param name='file8'>
            /// </param>
            /// <param name='file9'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListBulkItemDtoString> UploadPackageAsync(this ILibraries operations, Stream file, Stream file1 = default(Stream), Stream file2 = default(Stream), Stream file3 = default(Stream), Stream file4 = default(Stream), Stream file5 = default(Stream), Stream file6 = default(Stream), Stream file7 = default(Stream), Stream file8 = default(Stream), Stream file9 = default(Stream), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UploadPackageWithHttpMessagesAsync(file, file1, file2, file3, file4, file5, file6, file7, file8, file9, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
