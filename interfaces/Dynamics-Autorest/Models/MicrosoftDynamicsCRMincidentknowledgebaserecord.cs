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
    /// Microsoft.Dynamics.CRM.incidentknowledgebaserecord
    /// </summary>
    public partial class MicrosoftDynamicsCRMincidentknowledgebaserecord
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentknowledgebaserecord class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentknowledgebaserecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentknowledgebaserecord class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentknowledgebaserecord(int? utcconversiontimezonecode = default(int?), string incidentknowledgebaserecordid = default(string), string knowledgebaserecordid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string versionnumber = default(string), string incidentid = default(string), string name = default(string), int? timezoneruleversionnumber = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> incidentknowledgebaserecordAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> incidentknowledgebaserecordMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> incidentknowledgebaserecordBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> incidentknowledgebaserecordPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Incidentknowledgebaserecordid = incidentknowledgebaserecordid;
            Knowledgebaserecordid = knowledgebaserecordid;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            Incidentid = incidentid;
            Name = name;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            IncidentknowledgebaserecordAsyncOperations = incidentknowledgebaserecordAsyncOperations;
            IncidentknowledgebaserecordMailboxTrackingFolders = incidentknowledgebaserecordMailboxTrackingFolders;
            IncidentknowledgebaserecordBulkDeleteFailures = incidentknowledgebaserecordBulkDeleteFailures;
            IncidentknowledgebaserecordPrincipalObjectAttributeAccesses = incidentknowledgebaserecordPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentknowledgebaserecordid")]
        public string Incidentknowledgebaserecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecordid")]
        public string Knowledgebaserecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public string Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentknowledgebaserecord_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> IncidentknowledgebaserecordAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentknowledgebaserecord_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> IncidentknowledgebaserecordMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentknowledgebaserecord_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> IncidentknowledgebaserecordBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentknowledgebaserecord_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> IncidentknowledgebaserecordPrincipalObjectAttributeAccesses { get; set; }

    }
}
