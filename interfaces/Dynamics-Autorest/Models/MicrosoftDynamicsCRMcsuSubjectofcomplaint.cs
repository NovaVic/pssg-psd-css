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
    /// Microsoft.Dynamics.CRM.csu_subjectofcomplaint
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuSubjectofcomplaint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuSubjectofcomplaint class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuSubjectofcomplaint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuSubjectofcomplaint class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuSubjectofcomplaint(string csuCity = default(string), string csuNameofoccupants = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string csuDoingbusinessas = default(string), int? csuSubjecttype = default(int?), string csuMiddlename = default(string), string csuStateprovince = default(string), string csuSubjectofcomplaintid = default(string), int? statuscode = default(int?), string csuAddress2 = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string csuOtherpropertytype = default(string), string csuBcregistrybusinessname = default(string), string versionnumber = default(string), string csuProvince = default(string), string csuPrimaryphone = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string csuLastname = default(string), string _owninguserValue = default(string), System.DateTimeOffset? csuDateofbirth = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string csuAlias = default(string), string csuCountry = default(string), int? statecode = default(int?), int? csuAge = default(int?), string csuAddress1 = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string csuEmail = default(string), string csuBcregistrationnumber = default(string), string _owningteamValue = default(string), string emailaddress = default(string), int? csuPropertytype = default(int?), string _csuComplaintValue = default(string), string csuUrl = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string csuCalculatedage = default(string), int? csuAgetype = default(int?), string csuAddress3 = default(string), string csuFirstname = default(string), string csuName = default(string), string csuZippostalcode = default(string), int? importsequencenumber = default(int?), string csuAddressdescription = default(string), string csuRole = default(string), string csuNameofowners = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> csuSubjectofcomplaintActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> csuSubjectofcomplaintSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> csuSubjectofcomplaintActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> csuSubjectofcomplaintDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuSubjectofcomplaintDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuSubjectofcomplaintAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuSubjectofcomplaintMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuSubjectofcomplaintProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuSubjectofcomplaintBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuSubjectofcomplaintPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> csuSubjectofcomplaintAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> csuSubjectofcomplaintEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> csuSubjectofcomplaintFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> csuSubjectofcomplaintLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> csuSubjectofcomplaintPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> csuSubjectofcomplaintTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> csuSubjectofcomplaintRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> csuSubjectofcomplaintSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMserviceappointment> csuSubjectofcomplaintServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMcsuComplaints csuComplaint = default(MicrosoftDynamicsCRMcsuComplaints), IList<MicrosoftDynamicsCRMcsuCasetask> csuSubjectofcomplaintCsuCasetasks = default(IList<MicrosoftDynamicsCRMcsuCasetask>))
        {
            CsuCity = csuCity;
            CsuNameofoccupants = csuNameofoccupants;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            CsuDoingbusinessas = csuDoingbusinessas;
            CsuSubjecttype = csuSubjecttype;
            CsuMiddlename = csuMiddlename;
            CsuStateprovince = csuStateprovince;
            CsuSubjectofcomplaintid = csuSubjectofcomplaintid;
            Statuscode = statuscode;
            CsuAddress2 = csuAddress2;
            Modifiedon = modifiedon;
            CsuOtherpropertytype = csuOtherpropertytype;
            CsuBcregistrybusinessname = csuBcregistrybusinessname;
            Versionnumber = versionnumber;
            CsuProvince = csuProvince;
            CsuPrimaryphone = csuPrimaryphone;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            CsuLastname = csuLastname;
            this._owninguserValue = _owninguserValue;
            CsuDateofbirth = csuDateofbirth;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuAlias = csuAlias;
            CsuCountry = csuCountry;
            Statecode = statecode;
            CsuAge = csuAge;
            CsuAddress1 = csuAddress1;
            Createdon = createdon;
            CsuEmail = csuEmail;
            CsuBcregistrationnumber = csuBcregistrationnumber;
            this._owningteamValue = _owningteamValue;
            Emailaddress = emailaddress;
            CsuPropertytype = csuPropertytype;
            this._csuComplaintValue = _csuComplaintValue;
            CsuUrl = csuUrl;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            CsuCalculatedage = csuCalculatedage;
            CsuAgetype = csuAgetype;
            CsuAddress3 = csuAddress3;
            CsuFirstname = csuFirstname;
            CsuName = csuName;
            CsuZippostalcode = csuZippostalcode;
            Importsequencenumber = importsequencenumber;
            CsuAddressdescription = csuAddressdescription;
            CsuRole = csuRole;
            CsuNameofowners = csuNameofowners;
            this._createdbyValue = _createdbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuSubjectofcomplaintActivityPointers = csuSubjectofcomplaintActivityPointers;
            CsuSubjectofcomplaintSyncErrors = csuSubjectofcomplaintSyncErrors;
            CsuSubjectofcomplaintActivityParties = csuSubjectofcomplaintActivityParties;
            CsuSubjectofcomplaintDuplicateMatchingRecord = csuSubjectofcomplaintDuplicateMatchingRecord;
            CsuSubjectofcomplaintDuplicateBaseRecord = csuSubjectofcomplaintDuplicateBaseRecord;
            CsuSubjectofcomplaintAsyncOperations = csuSubjectofcomplaintAsyncOperations;
            CsuSubjectofcomplaintMailboxTrackingFolders = csuSubjectofcomplaintMailboxTrackingFolders;
            CsuSubjectofcomplaintProcessSession = csuSubjectofcomplaintProcessSession;
            CsuSubjectofcomplaintBulkDeleteFailures = csuSubjectofcomplaintBulkDeleteFailures;
            CsuSubjectofcomplaintPrincipalObjectAttributeAccesses = csuSubjectofcomplaintPrincipalObjectAttributeAccesses;
            CsuSubjectofcomplaintAppointments = csuSubjectofcomplaintAppointments;
            CsuSubjectofcomplaintEmails = csuSubjectofcomplaintEmails;
            CsuSubjectofcomplaintFaxes = csuSubjectofcomplaintFaxes;
            CsuSubjectofcomplaintLetters = csuSubjectofcomplaintLetters;
            CsuSubjectofcomplaintPhoneCalls = csuSubjectofcomplaintPhoneCalls;
            CsuSubjectofcomplaintTasks = csuSubjectofcomplaintTasks;
            CsuSubjectofcomplaintRecurringAppointmentMasters = csuSubjectofcomplaintRecurringAppointmentMasters;
            CsuSubjectofcomplaintSocialActivities = csuSubjectofcomplaintSocialActivities;
            CsuSubjectofcomplaintServiceAppointments = csuSubjectofcomplaintServiceAppointments;
            CsuComplaint = csuComplaint;
            CsuSubjectofcomplaintCsuCasetasks = csuSubjectofcomplaintCsuCasetasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_city")]
        public string CsuCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_nameofoccupants")]
        public string CsuNameofoccupants { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_doingbusinessas")]
        public string CsuDoingbusinessas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjecttype")]
        public int? CsuSubjecttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_middlename")]
        public string CsuMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_stateprovince")]
        public string CsuStateprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaintid")]
        public string CsuSubjectofcomplaintid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address2")]
        public string CsuAddress2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_otherpropertytype")]
        public string CsuOtherpropertytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_bcregistrybusinessname")]
        public string CsuBcregistrybusinessname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_province")]
        public string CsuProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_primaryphone")]
        public string CsuPrimaryphone { get; set; }

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
        [JsonProperty(PropertyName = "csu_lastname")]
        public string CsuLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_dateofbirth")]
        public System.DateTimeOffset? CsuDateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_alias")]
        public string CsuAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_country")]
        public string CsuCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_age")]
        public int? CsuAge { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address1")]
        public string CsuAddress1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_email")]
        public string CsuEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_bcregistrationnumber")]
        public string CsuBcregistrationnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_propertytype")]
        public int? CsuPropertytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_complaint_value")]
        public string _csuComplaintValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_url")]
        public string CsuUrl { get; set; }

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
        [JsonProperty(PropertyName = "csu_calculatedage")]
        public string CsuCalculatedage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_agetype")]
        public int? CsuAgetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address3")]
        public string CsuAddress3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_firstname")]
        public string CsuFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_zippostalcode")]
        public string CsuZippostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdescription")]
        public string CsuAddressdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_role")]
        public string CsuRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_nameofowners")]
        public string CsuNameofowners { get; set; }

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
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> CsuSubjectofcomplaintActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuSubjectofcomplaintSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CsuSubjectofcomplaintActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuSubjectofcomplaintDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuSubjectofcomplaintDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuSubjectofcomplaintAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuSubjectofcomplaintMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuSubjectofcomplaintProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuSubjectofcomplaintBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuSubjectofcomplaintPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> CsuSubjectofcomplaintAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_Emails")]
        public IList<MicrosoftDynamicsCRMemail> CsuSubjectofcomplaintEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> CsuSubjectofcomplaintFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_Letters")]
        public IList<MicrosoftDynamicsCRMletter> CsuSubjectofcomplaintLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> CsuSubjectofcomplaintPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> CsuSubjectofcomplaintTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> CsuSubjectofcomplaintRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> CsuSubjectofcomplaintSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> CsuSubjectofcomplaintServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_Complaint")]
        public MicrosoftDynamicsCRMcsuComplaints CsuComplaint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_subjectofcomplaint_csu_casetasks")]
        public IList<MicrosoftDynamicsCRMcsuCasetask> CsuSubjectofcomplaintCsuCasetasks { get; set; }

    }
}
