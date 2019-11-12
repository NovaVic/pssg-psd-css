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
    /// Microsoft.Dynamics.CRM.sdkmessageprocessingstepimage
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessageprocessingstepimage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepimage class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepimage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepimage class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepimage(int? componentstate = default(int?), string _createdonbehalfbyValue = default(string), string entityalias = default(string), string introducedversion = default(string), string attributes = default(string), bool? ismanaged = default(bool?), string _modifiedonbehalfbyValue = default(string), string sdkmessageprocessingstepimageidunique = default(string), string name = default(string), string _modifiedbyValue = default(string), string description = default(string), string iscustomizable = default(string), string _organizationidValue = default(string), string versionnumber = default(string), string messagepropertyname = default(string), string sdkmessageprocessingstepimageid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _sdkmessageprocessingstepidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string solutionid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? imagetype = default(int?), int? customizationlevel = default(int?), string relatedattributename = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsdkmessageprocessingstep sdkmessageprocessingstepid = default(MicrosoftDynamicsCRMsdkmessageprocessingstep))
        {
            Componentstate = componentstate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Entityalias = entityalias;
            Introducedversion = introducedversion;
            Attributes = attributes;
            Ismanaged = ismanaged;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Sdkmessageprocessingstepimageidunique = sdkmessageprocessingstepimageidunique;
            Name = name;
            this._modifiedbyValue = _modifiedbyValue;
            Description = description;
            Iscustomizable = iscustomizable;
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            Messagepropertyname = messagepropertyname;
            Sdkmessageprocessingstepimageid = sdkmessageprocessingstepimageid;
            Modifiedon = modifiedon;
            this._sdkmessageprocessingstepidValue = _sdkmessageprocessingstepidValue;
            Createdon = createdon;
            Solutionid = solutionid;
            Overwritetime = overwritetime;
            Imagetype = imagetype;
            Customizationlevel = customizationlevel;
            Relatedattributename = relatedattributename;
            this._createdbyValue = _createdbyValue;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Sdkmessageprocessingstepid = sdkmessageprocessingstepid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityalias")]
        public string Entityalias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepimageidunique")]
        public string Sdkmessageprocessingstepimageidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messagepropertyname")]
        public string Messagepropertyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepimageid")]
        public string Sdkmessageprocessingstepimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageprocessingstepid_value")]
        public string _sdkmessageprocessingstepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imagetype")]
        public int? Imagetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedattributename")]
        public string Relatedattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

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
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepid")]
        public MicrosoftDynamicsCRMsdkmessageprocessingstep Sdkmessageprocessingstepid { get; set; }

    }
}
