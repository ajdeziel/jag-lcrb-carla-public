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
    /// Microsoft.Dynamics.CRM.msdyn_playbookactivityattribute
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynPlaybookactivityattribute
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPlaybookactivityattribute class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPlaybookactivityattribute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPlaybookactivityattribute class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPlaybookactivityattribute(int? utcconversiontimezonecode = default(int?), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string msdynAttributeLogicalName = default(string), string msdynPlaybookactivityattributeid = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _msdynPlaybookactivityidValue = default(string), string _owningbusinessunitValue = default(string), string versionnumber = default(string), string _createdbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), int? msdynAttributeType = default(int?), int? statecode = default(int?), string msdynAttributeValue = default(string), int? statuscode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynPlaybookactivityattributeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPlaybookactivityattributeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPlaybookactivityattributeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynPlaybookactivityattributeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynPlaybookactivityattributeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynPlaybookactivityattributeProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynPlaybookactivityattributeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynPlaybookactivityattributePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynPlaybookactivity msdynPlaybookactivityid = default(MicrosoftDynamicsCRMmsdynPlaybookactivity))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            MsdynAttributeLogicalName = msdynAttributeLogicalName;
            MsdynPlaybookactivityattributeid = msdynPlaybookactivityattributeid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._msdynPlaybookactivityidValue = _msdynPlaybookactivityidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynAttributeType = msdynAttributeType;
            Statecode = statecode;
            MsdynAttributeValue = msdynAttributeValue;
            Statuscode = statuscode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynPlaybookactivityattributeSyncErrors = msdynPlaybookactivityattributeSyncErrors;
            MsdynPlaybookactivityattributeDuplicateMatchingRecord = msdynPlaybookactivityattributeDuplicateMatchingRecord;
            MsdynPlaybookactivityattributeDuplicateBaseRecord = msdynPlaybookactivityattributeDuplicateBaseRecord;
            MsdynPlaybookactivityattributeAsyncOperations = msdynPlaybookactivityattributeAsyncOperations;
            MsdynPlaybookactivityattributeMailboxTrackingFolders = msdynPlaybookactivityattributeMailboxTrackingFolders;
            MsdynPlaybookactivityattributeProcessSession = msdynPlaybookactivityattributeProcessSession;
            MsdynPlaybookactivityattributeBulkDeleteFailures = msdynPlaybookactivityattributeBulkDeleteFailures;
            MsdynPlaybookactivityattributePrincipalObjectAttributeAccesses = msdynPlaybookactivityattributePrincipalObjectAttributeAccesses;
            MsdynPlaybookactivityid = msdynPlaybookactivityid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_attributeLogicalName")]
        public string MsdynAttributeLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattributeid")]
        public string MsdynPlaybookactivityattributeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_playbookactivityid_value")]
        public string _msdynPlaybookactivityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_attributeType")]
        public int? MsdynAttributeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_attributeValue")]
        public string MsdynAttributeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynPlaybookactivityattributeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPlaybookactivityattributeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPlaybookactivityattributeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynPlaybookactivityattributeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynPlaybookactivityattributeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynPlaybookactivityattributeProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynPlaybookactivityattributeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynPlaybookactivityattributePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookactivityid")]
        public MicrosoftDynamicsCRMmsdynPlaybookactivity MsdynPlaybookactivityid { get; set; }

    }
}