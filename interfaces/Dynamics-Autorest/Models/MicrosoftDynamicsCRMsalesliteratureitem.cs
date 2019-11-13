// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.salesliteratureitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMsalesliteratureitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem(string filename = default(string), string organizationid = default(string), string documentbody = default(string), byte[] documentbodyBinary = default(byte[]), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), bool? iscustomerviewable = default(bool?), string attacheddocumenturl = default(string), string mimetype = default(string), string keywords = default(string), string abstractProperty = default(string), string authorname = default(string), int? filesize = default(int?), string salesliteratureitemid = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? filetypecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string title = default(string), string _modifiedonbehalfbyValue = default(string), string _salesliteratureidValue = default(string), string mode = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> salesliteratureitemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> salesLiteratureItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> salesliteratureitemMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> salesLiteratureItemProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesLiteratureItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> salesliteratureitemPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsalesliterature salesliteratureid = default(MicrosoftDynamicsCRMsalesliterature))
        {
            Filename = filename;
            Organizationid = organizationid;
            Documentbody = documentbody;
            DocumentbodyBinary = documentbodyBinary;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Iscustomerviewable = iscustomerviewable;
            Attacheddocumenturl = attacheddocumenturl;
            Mimetype = mimetype;
            Keywords = keywords;
            AbstractProperty = abstractProperty;
            Authorname = authorname;
            Filesize = filesize;
            Salesliteratureitemid = salesliteratureitemid;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Filetypecode = filetypecode;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Title = title;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._salesliteratureidValue = _salesliteratureidValue;
            Mode = mode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            SalesliteratureitemSyncErrors = salesliteratureitemSyncErrors;
            SalesLiteratureItemAsyncOperations = salesLiteratureItemAsyncOperations;
            SalesliteratureitemMailboxTrackingFolders = salesliteratureitemMailboxTrackingFolders;
            SalesLiteratureItemProcessSessions = salesLiteratureItemProcessSessions;
            SalesLiteratureItemBulkDeleteFailures = salesLiteratureItemBulkDeleteFailures;
            SalesliteratureitemPrincipalObjectAttributeAccesses = salesliteratureitemPrincipalObjectAttributeAccesses;
            Salesliteratureid = salesliteratureid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody")]
        public string Documentbody { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "documentbody_binary")]
        public byte[] DocumentbodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomerviewable")]
        public bool? Iscustomerviewable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attacheddocumenturl")]
        public string Attacheddocumenturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public string AbstractProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorname")]
        public string Authorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitemid")]
        public string Salesliteratureitemid { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "filetypecode")]
        public int? Filetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesliteratureid_value")]
        public string _salesliteratureidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "salesliteratureitem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SalesliteratureitemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesLiteratureItemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SalesliteratureitemMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SalesLiteratureItemProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesLiteratureItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SalesliteratureitemPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureid")]
        public MicrosoftDynamicsCRMsalesliterature Salesliteratureid { get; set; }

    }
}
