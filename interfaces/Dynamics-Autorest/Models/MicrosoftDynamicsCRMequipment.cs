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
    /// Microsoft.Dynamics.CRM.equipment
    /// </summary>
    public partial class MicrosoftDynamicsCRMequipment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMequipment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMequipment(bool? displayinserviceviews = default(bool?), string _modifiedbyValue = default(string), string _siteidValue = default(string), string _modifiedonbehalfbyValue = default(string), string equipmentid = default(string), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), string _transactioncurrencyidValue = default(string), string description = default(string), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _businessunitidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string skills = default(string), bool? isdisabled = default(bool?), decimal? exchangerate = default(decimal?), string _calendaridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? timezonecode = default(int?), string versionnumber = default(string), int? importsequencenumber = default(int?), string emailaddress = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string name = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> equipmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> equipmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> equipmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> equipmentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> equipmentProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> equipmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> equipmentPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> equipmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> equipmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> equipmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), IList<MicrosoftDynamicsCRMemail> equipmentEmailEmailSender = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMaccount> equipmentAccounts = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMcontact> equipmentContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMresource> equipmentResources = default(IList<MicrosoftDynamicsCRMresource>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite))
        {
            Displayinserviceviews = displayinserviceviews;
            this._modifiedbyValue = _modifiedbyValue;
            this._siteidValue = _siteidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Equipmentid = equipmentid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Description = description;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._businessunitidValue = _businessunitidValue;
            Createdon = createdon;
            Skills = skills;
            Isdisabled = isdisabled;
            Exchangerate = exchangerate;
            this._calendaridValue = _calendaridValue;
            Modifiedon = modifiedon;
            Timezonecode = timezonecode;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Emailaddress = emailaddress;
            Overriddencreatedon = overriddencreatedon;
            Name = name;
            this._createdbyValue = _createdbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            EquipmentSyncErrors = equipmentSyncErrors;
            EquipmentActivityParties = equipmentActivityParties;
            EquipmentDuplicateMatchingRecord = equipmentDuplicateMatchingRecord;
            EquipmentDuplicateBaseRecord = equipmentDuplicateBaseRecord;
            EquipmentAsyncOperations = equipmentAsyncOperations;
            EquipmentMailboxTrackingFolders = equipmentMailboxTrackingFolders;
            EquipmentProcessSessions = equipmentProcessSessions;
            EquipmentBulkDeleteFailures = equipmentBulkDeleteFailures;
            EquipmentPrincipalobjectattributeaccess = equipmentPrincipalobjectattributeaccess;
            EquipmentConnections1 = equipmentConnections1;
            EquipmentConnections2 = equipmentConnections2;
            EquipmentAnnotation = equipmentAnnotation;
            Calendarid = calendarid;
            EquipmentEmailEmailSender = equipmentEmailEmailSender;
            EquipmentAccounts = equipmentAccounts;
            EquipmentContacts = equipmentContacts;
            EquipmentResources = equipmentResources;
            Organizationid = organizationid;
            BusinessunitidSystemuser = businessunitidSystemuser;
            Transactioncurrencyid = transactioncurrencyid;
            Siteid = siteid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayinserviceviews")]
        public bool? Displayinserviceviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipmentid")]
        public string Equipmentid { get; set; }

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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skills")]
        public string Skills { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdisabled")]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EquipmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> EquipmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EquipmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EquipmentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> EquipmentProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EquipmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EquipmentPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> EquipmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Email_EmailSender")]
        public IList<MicrosoftDynamicsCRMemail> EquipmentEmailEmailSender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> EquipmentAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_contacts")]
        public IList<MicrosoftDynamicsCRMcontact> EquipmentContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_resources")]
        public IList<MicrosoftDynamicsCRMresource> EquipmentResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

    }
}
