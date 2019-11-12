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
    /// Microsoft.Dynamics.CRM.transformationparametermapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMtransformationparametermapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtransformationparametermapping class.
        /// </summary>
        public MicrosoftDynamicsCRMtransformationparametermapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtransformationparametermapping class.
        /// </summary>
        public MicrosoftDynamicsCRMtransformationparametermapping(string _transformationmappingidValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? parametersequence = default(int?), int? parameterarrayindex = default(int?), string _modifiedbyValue = default(string), string introducedversion = default(string), int? componentstate = default(int?), string data = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? datatypecode = default(int?), string transformationparametermappingidunique = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string solutionid = default(string), int? parametertypecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string transformationparametermappingid = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMtransformationmapping transformationmappingid = default(MicrosoftDynamicsCRMtransformationmapping), IList<MicrosoftDynamicsCRMlookupmapping> lookUpMappingTransformationParameterMapping = default(IList<MicrosoftDynamicsCRMlookupmapping>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._transformationmappingidValue = _transformationmappingidValue;
            Overwritetime = overwritetime;
            Parametersequence = parametersequence;
            Parameterarrayindex = parameterarrayindex;
            this._modifiedbyValue = _modifiedbyValue;
            Introducedversion = introducedversion;
            Componentstate = componentstate;
            Data = data;
            Ismanaged = ismanaged;
            Modifiedon = modifiedon;
            Datatypecode = datatypecode;
            Transformationparametermappingidunique = transformationparametermappingidunique;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Solutionid = solutionid;
            Parametertypecode = parametertypecode;
            Createdon = createdon;
            Transformationparametermappingid = transformationparametermappingid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Transformationmappingid = transformationmappingid;
            LookUpMappingTransformationParameterMapping = lookUpMappingTransformationParameterMapping;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transformationmappingid_value")]
        public string _transformationmappingidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parametersequence")]
        public int? Parametersequence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameterarrayindex")]
        public int? Parameterarrayindex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datatypecode")]
        public int? Datatypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transformationparametermappingidunique")]
        public string Transformationparametermappingidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parametertypecode")]
        public int? Parametertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transformationparametermappingid")]
        public string Transformationparametermappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transformationmappingid")]
        public MicrosoftDynamicsCRMtransformationmapping Transformationmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LookUpMapping_TransformationParameterMapping")]
        public IList<MicrosoftDynamicsCRMlookupmapping> LookUpMappingTransformationParameterMapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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

    }
}
