// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of csu_demandandorder
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_demandandorderCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuDemandandorderCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuDemandandorderCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuDemandandorderCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuDemandandorderCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuDemandandorderCollection(IList<MicrosoftDynamicsCRMcsuDemandandorder> value = default(IList<MicrosoftDynamicsCRMcsuDemandandorder>))
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
        public IList<MicrosoftDynamicsCRMcsuDemandandorder> Value { get; set; }

    }
}
