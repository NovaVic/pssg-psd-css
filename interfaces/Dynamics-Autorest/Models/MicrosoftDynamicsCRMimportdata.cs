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
    /// Microsoft.Dynamics.CRM.importdata
    /// </summary>
    public partial class MicrosoftDynamicsCRMimportdata
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportdata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportdata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportdata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportdata(bool? haserror = default(bool?), string _owninguserValue = default(string), int? linenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owneridValue = default(string), string _importfileidValue = default(string), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), int? errortype = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string recordid = default(string), string _createdbyValue = default(string), string data = default(string), string importdataid = default(string), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> importDataAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMimportfile importfileid = default(MicrosoftDynamicsCRMimportfile), IList<MicrosoftDynamicsCRMimportlog> importLogImportData = default(IList<MicrosoftDynamicsCRMimportlog>), IList<MicrosoftDynamicsCRMbulkdeletefailure> importDataBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Haserror = haserror;
            this._owninguserValue = _owninguserValue;
            Linenumber = linenumber;
            Createdon = createdon;
            this._owneridValue = _owneridValue;
            this._importfileidValue = _importfileidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            Errortype = errortype;
            Modifiedon = modifiedon;
            this._owningteamValue = _owningteamValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Recordid = recordid;
            this._createdbyValue = _createdbyValue;
            Data = data;
            Importdataid = importdataid;
            Owninguser = owninguser;
            Modifiedby = modifiedby;
            ImportDataAsyncOperations = importDataAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owningteam = owningteam;
            Importfileid = importfileid;
            ImportLogImportData = importLogImportData;
            ImportDataBulkDeleteFailures = importDataBulkDeleteFailures;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "haserror")]
        public bool? Haserror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "linenumber")]
        public int? Linenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importfileid_value")]
        public string _importfileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errortype")]
        public int? Errortype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordid")]
        public string Recordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importdataid")]
        public string Importdataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportData_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportDataAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importfileid")]
        public MicrosoftDynamicsCRMimportfile Importfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_ImportData")]
        public IList<MicrosoftDynamicsCRMimportlog> ImportLogImportData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportData_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportDataBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
