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
    /// Microsoft.Dynamics.CRM.accountleads
    /// </summary>
    public partial class MicrosoftDynamicsCRMaccountleads
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaccountleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMaccountleads()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaccountleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMaccountleads(string accountleadid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string name = default(string), string accountid = default(string), int? utcconversiontimezonecode = default(int?), string leadid = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> accountleadsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> accountleadsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> accountleadsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> accountleadsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Accountleadid = accountleadid;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Accountid = accountid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Leadid = leadid;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            AccountleadsAsyncOperations = accountleadsAsyncOperations;
            AccountleadsMailboxTrackingFolders = accountleadsMailboxTrackingFolders;
            AccountleadsBulkDeleteFailures = accountleadsBulkDeleteFailures;
            AccountleadsPrincipalObjectAttributeAccesses = accountleadsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountleadid")]
        public string Accountleadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountid")]
        public string Accountid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadid")]
        public string Leadid { get; set; }

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
        [JsonProperty(PropertyName = "accountleads_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AccountleadsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountleads_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AccountleadsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountleads_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AccountleadsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountleads_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AccountleadsPrincipalObjectAttributeAccesses { get; set; }

    }
}
