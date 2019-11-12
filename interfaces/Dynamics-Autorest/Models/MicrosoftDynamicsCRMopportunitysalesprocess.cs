// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.opportunitysalesprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunitysalesprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitysalesprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitysalesprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitysalesprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitysalesprocess(string _createdbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string businessprocessflowinstanceid = default(string), string name = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _processidValue = default(string), string _quoteidValue = default(string), decimal? exchangerate = default(decimal?), string traversedpath = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _salesorderidValue = default(string), int? duration = default(int?), string _activestageidValue = default(string), string _opportunityidValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> opportunitySalesProcessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> opportunitysalesprocessAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> workflowlogsOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> opportunitysalesprocessMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> opportunitysalesprocessProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunitysalesprocessBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> opportunitysalesprocessPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Name = name;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._processidValue = _processidValue;
            this._quoteidValue = _quoteidValue;
            Exchangerate = exchangerate;
            Traversedpath = traversedpath;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            this._salesorderidValue = _salesorderidValue;
            Duration = duration;
            this._activestageidValue = _activestageidValue;
            this._opportunityidValue = _opportunityidValue;
            Statuscode = statuscode;
            Completedon = completedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Activestagestartedon = activestagestartedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            Activestageid = activestageid;
            Processid = processid;
            OpportunitySalesProcessSyncErrors = opportunitySalesProcessSyncErrors;
            OpportunitysalesprocessAsyncOperations = opportunitysalesprocessAsyncOperations;
            WorkflowlogsOpportunitysalesprocess = workflowlogsOpportunitysalesprocess;
            OpportunitysalesprocessMailboxTrackingFolders = opportunitysalesprocessMailboxTrackingFolders;
            OpportunitysalesprocessProcessSession = opportunitysalesprocessProcessSession;
            OpportunitysalesprocessBulkDeleteFailures = opportunitysalesprocessBulkDeleteFailures;
            OpportunitysalesprocessPrincipalObjectAttributeAccesses = opportunitysalesprocessPrincipalObjectAttributeAccesses;
            Opportunityid = opportunityid;
            Quoteid = quoteid;
            Salesorderid = salesorderid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

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
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunitySalesProcess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunitySalesProcessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitysalesprocess_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunitysalesprocessAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogs_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMworkflowlog> WorkflowlogsOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitysalesprocess_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OpportunitysalesprocessMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitysalesprocess_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> OpportunitysalesprocessProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitysalesprocess_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunitysalesprocessBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitysalesprocess_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> OpportunitysalesprocessPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
