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
    /// Extension methods for Specialeventareaeventschedules.
    /// </summary>
    public static partial class SpecialeventareaeventschedulesExtensions
    {
            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
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
            public static MicrosoftDynamicsCRMadoxioSpecialeventscheduleCollection Get(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioSpecialeventlicencedareaid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
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
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventscheduleCollection> GetAsync(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioSpecialeventlicencedareaid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventscheduleCollection> GetWithHttpMessages(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioSpecialeventlicencedareaid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
            /// </param>
            /// <param name='adoxioSpecialeventscheduleid'>
            /// key: adoxio_specialeventscheduleid of adoxio_specialeventschedule
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSpecialeventschedule EventschedulesByKey(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, string adoxioSpecialeventscheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.EventschedulesByKeyAsync(adoxioSpecialeventlicencedareaid, adoxioSpecialeventscheduleid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
            /// </param>
            /// <param name='adoxioSpecialeventscheduleid'>
            /// key: adoxio_specialeventscheduleid of adoxio_specialeventschedule
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
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventschedule> EventschedulesByKeyAsync(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, string adoxioSpecialeventscheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EventschedulesByKeyWithHttpMessagesAsync(adoxioSpecialeventlicencedareaid, adoxioSpecialeventscheduleid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialeventarea_eventschedules from
            /// adoxio_specialeventlicencedareas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventlicencedareaid'>
            /// key: adoxio_specialeventlicencedareaid of adoxio_specialeventlicencedarea
            /// </param>
            /// <param name='adoxioSpecialeventscheduleid'>
            /// key: adoxio_specialeventscheduleid of adoxio_specialeventschedule
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventschedule> EventschedulesByKeyWithHttpMessages(this ISpecialeventareaeventschedules operations, string adoxioSpecialeventlicencedareaid, string adoxioSpecialeventscheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.EventschedulesByKeyWithHttpMessagesAsync(adoxioSpecialeventlicencedareaid, adoxioSpecialeventscheduleid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
