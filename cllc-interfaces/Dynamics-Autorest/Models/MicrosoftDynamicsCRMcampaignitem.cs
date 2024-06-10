// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.campaignitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMcampaignitem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcampaignitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcampaignitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignitem(string owninguser = default(string), string versionnumber = default(string), string entityid = default(string), string owningbusinessunit = default(string), int? timezoneruleversionnumber = default(int?), string _campaignidValue = default(string), string _owneridValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string entitytype = default(string), string name = default(string), int? utcconversiontimezonecode = default(int?), string campaignitemid = default(string), IList<MicrosoftDynamicsCRMteam> campaignitemTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> campaignitemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> campaignitemMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> campaignitemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> campaignitemPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Owninguser = owninguser;
            Versionnumber = versionnumber;
            Entityid = entityid;
            Owningbusinessunit = owningbusinessunit;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._campaignidValue = _campaignidValue;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            Entitytype = entitytype;
            Name = name;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Campaignitemid = campaignitemid;
            CampaignitemTeams = campaignitemTeams;
            CampaignitemAsyncOperations = campaignitemAsyncOperations;
            CampaignitemMailboxTrackingFolders = campaignitemMailboxTrackingFolders;
            CampaignitemBulkDeleteFailures = campaignitemBulkDeleteFailures;
            CampaignitemPrincipalObjectAttributeAccesses = campaignitemPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityid")]
        public string Entityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_campaignid_value")]
        public string _campaignidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitytype")]
        public string Entitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitemid")]
        public string Campaignitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitem_Teams")]
        public IList<MicrosoftDynamicsCRMteam> CampaignitemTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CampaignitemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitem_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CampaignitemMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CampaignitemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignitem_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CampaignitemPrincipalObjectAttributeAccesses { get; set; }

    }
}
