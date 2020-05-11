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
    /// Extension methods for Auditlogrequestprincipalobjectattributeaccesses.
    /// </summary>
    public static partial class AuditlogrequestprincipalobjectattributeaccessesExtensions
    {
            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
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
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection Get(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioAuditlogrequestid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetAsync(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioAuditlogrequestid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetWithHttpMessages(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioAuditlogrequestid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccess PrincipalObjectAttributeAccessesByKey(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.PrincipalObjectAttributeAccessesByKeyAsync(adoxioAuditlogrequestid, principalobjectattributeaccessid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyAsync(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(adoxioAuditlogrequestid, principalobjectattributeaccessid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_auditlogrequest_PrincipalObjectAttributeAccesses from
            /// adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyWithHttpMessages(this IAuditlogrequestprincipalobjectattributeaccesses operations, string adoxioAuditlogrequestid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(adoxioAuditlogrequestid, principalobjectattributeaccessid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}