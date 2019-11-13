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
    /// Microsoft.Dynamics.CRM.resourcegroup
    /// </summary>
    public partial class MicrosoftDynamicsCRMresourcegroup
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcegroup
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcegroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcegroup
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcegroup(string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string name = default(string), int? importsequencenumber = default(int?), string _organizationidValue = default(string), string _businessunitidValue = default(string), string resourcegroupid = default(string), int? utcconversiontimezonecode = default(int?), string objecttypecode = default(string), int? grouptypecode = default(int?), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> resourceGroupSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> resourceGroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> resourcegroupMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> resourceGroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> resourcegroupPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> resourcegroupConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> resourcegroupConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMconstraintbasedgroup resourcegroupidConstraintbasedgroup = default(MicrosoftDynamicsCRMconstraintbasedgroup), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMduplicaterecord> resourceGroupDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> resourceGroupDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMteam resourcegroupidTeam = default(MicrosoftDynamicsCRMteam))
        {
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Importsequencenumber = importsequencenumber;
            this._organizationidValue = _organizationidValue;
            this._businessunitidValue = _businessunitidValue;
            Resourcegroupid = resourcegroupid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Objecttypecode = objecttypecode;
            Grouptypecode = grouptypecode;
            Businessunitid = businessunitid;
            ResourceGroupSyncErrors = resourceGroupSyncErrors;
            ResourceGroupAsyncOperations = resourceGroupAsyncOperations;
            ResourcegroupMailboxTrackingFolders = resourcegroupMailboxTrackingFolders;
            ResourceGroupBulkDeleteFailures = resourceGroupBulkDeleteFailures;
            ResourcegroupPrincipalObjectAttributeAccesses = resourcegroupPrincipalObjectAttributeAccesses;
            ResourcegroupConnections1 = resourcegroupConnections1;
            ResourcegroupConnections2 = resourcegroupConnections2;
            ResourcegroupidConstraintbasedgroup = resourcegroupidConstraintbasedgroup;
            Organizationid = organizationid;
            ResourceGroupDuplicateBaseRecord = resourceGroupDuplicateBaseRecord;
            ResourceGroupDuplicateMatchingRecord = resourceGroupDuplicateMatchingRecord;
            ResourcegroupidTeam = resourcegroupidTeam;
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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid")]
        public string Resourcegroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grouptypecode")]
        public int? Grouptypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ResourceGroupSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ResourceGroupAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ResourcegroupMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ResourceGroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ResourcegroupPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ResourcegroupConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ResourcegroupConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid_constraintbasedgroup")]
        public MicrosoftDynamicsCRMconstraintbasedgroup ResourcegroupidConstraintbasedgroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ResourceGroupDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ResourceGroupDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid_team")]
        public MicrosoftDynamicsCRMteam ResourcegroupidTeam { get; set; }

    }
}
