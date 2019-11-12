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
    /// Microsoft.Dynamics.CRM.csu_phonehistory
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuPhonehistory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuPhonehistory class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuPhonehistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuPhonehistory class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuPhonehistory(string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string _csuPersondetailidValue = default(string), int? importsequencenumber = default(int?), int? statecode = default(int?), string _createdbyValue = default(string), int? statuscode = default(int?), string csuPhonehistoryid = default(string), bool? csuCurrent = default(bool?), string _owningteamValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string csuNumber = default(string), string _owneridValue = default(string), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? csuUsedfromdate = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? csuPhonetype = default(int?), System.DateTimeOffset? csuUsedtodate = default(System.DateTimeOffset?), string csuName = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuPhonehistorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuPhonehistoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuPhonehistoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuPhonehistoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuPhonehistoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuPhonehistoryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuPhonehistoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuPhonehistoryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcontact csuPersonDetailId = default(MicrosoftDynamicsCRMcontact))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._csuPersondetailidValue = _csuPersondetailidValue;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            CsuPhonehistoryid = csuPhonehistoryid;
            CsuCurrent = csuCurrent;
            this._owningteamValue = _owningteamValue;
            Overriddencreatedon = overriddencreatedon;
            CsuNumber = csuNumber;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CsuUsedfromdate = csuUsedfromdate;
            Modifiedon = modifiedon;
            CsuPhonetype = csuPhonetype;
            CsuUsedtodate = csuUsedtodate;
            CsuName = csuName;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuPhonehistorySyncErrors = csuPhonehistorySyncErrors;
            CsuPhonehistoryDuplicateMatchingRecord = csuPhonehistoryDuplicateMatchingRecord;
            CsuPhonehistoryDuplicateBaseRecord = csuPhonehistoryDuplicateBaseRecord;
            CsuPhonehistoryAsyncOperations = csuPhonehistoryAsyncOperations;
            CsuPhonehistoryMailboxTrackingFolders = csuPhonehistoryMailboxTrackingFolders;
            CsuPhonehistoryProcessSession = csuPhonehistoryProcessSession;
            CsuPhonehistoryBulkDeleteFailures = csuPhonehistoryBulkDeleteFailures;
            CsuPhonehistoryPrincipalObjectAttributeAccesses = csuPhonehistoryPrincipalObjectAttributeAccesses;
            CsuPersonDetailId = csuPersonDetailId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_persondetailid_value")]
        public string _csuPersondetailidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistoryid")]
        public string CsuPhonehistoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_current")]
        public bool? CsuCurrent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_number")]
        public string CsuNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_usedfromdate")]
        public System.DateTimeOffset? CsuUsedfromdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonetype")]
        public int? CsuPhonetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_usedtodate")]
        public System.DateTimeOffset? CsuUsedtodate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuPhonehistorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuPhonehistoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuPhonehistoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuPhonehistoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuPhonehistoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuPhonehistoryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuPhonehistoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_phonehistory_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuPhonehistoryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_PersonDetailId")]
        public MicrosoftDynamicsCRMcontact CsuPersonDetailId { get; set; }

    }
}
