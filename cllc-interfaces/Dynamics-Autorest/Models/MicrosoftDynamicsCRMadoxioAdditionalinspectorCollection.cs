// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of adoxio_additionalinspector
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_additionalinspectorCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection(IList<MicrosoftDynamicsCRMadoxioAdditionalinspector> value = default(IList<MicrosoftDynamicsCRMadoxioAdditionalinspector>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioAdditionalinspector> Value { get; set; }

    }
}
