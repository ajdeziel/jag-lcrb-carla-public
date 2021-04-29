// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Additionalinspectorsyncerrors.
    /// </summary>
    public static partial class AdditionalinspectorsyncerrorsExtensions
    {
            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsyncerrorCollection Get(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioAdditionalinspectorid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsyncerrorCollection> GetAsync(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioAdditionalinspectorid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsyncerrorCollection> GetWithHttpMessages(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioAdditionalinspectorid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsyncerror SyncErrorsByKey(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.SyncErrorsByKeyAsync(adoxioAdditionalinspectorid, syncerrorid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsyncerror> SyncErrorsByKeyAsync(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SyncErrorsByKeyWithHttpMessagesAsync(adoxioAdditionalinspectorid, syncerrorid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_additionalinspector_SyncErrors from adoxio_additionalinspectors
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='syncerrorid'>
            /// key: syncerrorid of syncerror
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsyncerror> SyncErrorsByKeyWithHttpMessages(this IAdditionalinspectorsyncerrors operations, string adoxioAdditionalinspectorid, string syncerrorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.SyncErrorsByKeyWithHttpMessagesAsync(adoxioAdditionalinspectorid, syncerrorid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
