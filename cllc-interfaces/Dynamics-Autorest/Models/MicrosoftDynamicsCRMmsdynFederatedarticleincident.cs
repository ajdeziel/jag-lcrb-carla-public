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
    /// Microsoft.Dynamics.CRM.msdyn_federatedarticleincident
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynFederatedarticleincident
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynFederatedarticleincident class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynFederatedarticleincident()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynFederatedarticleincident class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynFederatedarticleincident(string _createdonbehalfbyValue = default(string), string _msdynIncidentidValue = default(string), string msdynName = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string msdynSearchproviderarticleid = default(string), int? importsequencenumber = default(int?), string _organizationidValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? statuscode = default(int?), int? statecode = default(int?), string msdynFederatedarticleincidentid = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _msdynFederatedarticleidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> msdynFederatedarticleincidentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynFederatedarticleincidentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynFederatedarticleincidentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynFederatedarticleincidentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynFederatedarticleincidentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynFederatedarticleincidentProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynFederatedarticleincidentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynFederatedarticleincidentPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMincident msdynIncidentid = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMmsdynFederatedarticle msdynFederatedarticleid = default(MicrosoftDynamicsCRMmsdynFederatedarticle))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._msdynIncidentidValue = _msdynIncidentidValue;
            MsdynName = msdynName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            MsdynSearchproviderarticleid = msdynSearchproviderarticleid;
            Importsequencenumber = importsequencenumber;
            this._organizationidValue = _organizationidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            Statecode = statecode;
            MsdynFederatedarticleincidentid = msdynFederatedarticleincidentid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            this._msdynFederatedarticleidValue = _msdynFederatedarticleidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MsdynFederatedarticleincidentSyncErrors = msdynFederatedarticleincidentSyncErrors;
            MsdynFederatedarticleincidentDuplicateMatchingRecord = msdynFederatedarticleincidentDuplicateMatchingRecord;
            MsdynFederatedarticleincidentDuplicateBaseRecord = msdynFederatedarticleincidentDuplicateBaseRecord;
            MsdynFederatedarticleincidentAsyncOperations = msdynFederatedarticleincidentAsyncOperations;
            MsdynFederatedarticleincidentMailboxTrackingFolders = msdynFederatedarticleincidentMailboxTrackingFolders;
            MsdynFederatedarticleincidentProcessSession = msdynFederatedarticleincidentProcessSession;
            MsdynFederatedarticleincidentBulkDeleteFailures = msdynFederatedarticleincidentBulkDeleteFailures;
            MsdynFederatedarticleincidentPrincipalObjectAttributeAccesses = msdynFederatedarticleincidentPrincipalObjectAttributeAccesses;
            MsdynIncidentid = msdynIncidentid;
            MsdynFederatedarticleid = msdynFederatedarticleid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_incidentid_value")]
        public string _msdynIncidentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_searchproviderarticleid")]
        public string MsdynSearchproviderarticleid { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincidentid")]
        public string MsdynFederatedarticleincidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_federatedarticleid_value")]
        public string _msdynFederatedarticleidValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynFederatedarticleincidentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynFederatedarticleincidentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynFederatedarticleincidentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynFederatedarticleincidentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynFederatedarticleincidentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynFederatedarticleincidentProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynFederatedarticleincidentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynFederatedarticleincidentPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_incidentid")]
        public MicrosoftDynamicsCRMincident MsdynIncidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleid")]
        public MicrosoftDynamicsCRMmsdynFederatedarticle MsdynFederatedarticleid { get; set; }

    }
}