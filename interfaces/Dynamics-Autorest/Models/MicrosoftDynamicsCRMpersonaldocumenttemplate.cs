// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.personaldocumenttemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMpersonaldocumenttemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpersonaldocumenttemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMpersonaldocumenttemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpersonaldocumenttemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMpersonaldocumenttemplate(string versionnumber = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string personaldocumenttemplateid = default(string), string _owninguserValue = default(string), string content = default(string), string _createdonbehalfbyValue = default(string), bool? status = default(bool?), string name = default(string), int? documenttype = default(int?), string clientdata = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _owneridValue = default(string), string _owningteamValue = default(string), int? languagecode = default(int?), string description = default(string), string _owningbusinessunitValue = default(string), string associatedentitytypecode = default(string), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Personaldocumenttemplateid = personaldocumenttemplateid;
            this._owninguserValue = _owninguserValue;
            Content = content;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Status = status;
            Name = name;
            Documenttype = documenttype;
            Clientdata = clientdata;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            Languagecode = languagecode;
            Description = description;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Associatedentitytypecode = associatedentitytypecode;
            Ownerid = ownerid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Owningbusinessunit = owningbusinessunit;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "personaldocumenttemplateid")]
        public string Personaldocumenttemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public bool? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documenttype")]
        public int? Documenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associatedentitytypecode")]
        public string Associatedentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
