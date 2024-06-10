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
    /// Microsoft.Dynamics.CRM.adoxio_annualvolume
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioAnnualvolume
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAnnualvolume class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAnnualvolume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAnnualvolume class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAnnualvolume(int? statecode = default(int?), int? adoxioVolumedestroyed = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioDatesubmitted = default(System.DateTimeOffset?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), string _owningteamValue = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioVolumeproduced = default(int?), string _adoxioApplicationValue = default(string), string versionnumber = default(string), string adoxioName = default(string), string _owninguserValue = default(string), string _adoxioLicenceValue = default(string), int? importsequencenumber = default(int?), string adoxioAnnualvolumeid = default(string), string adoxioCalendaryear = default(string), int? adoxioCalendaryearint = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioAnnualvolumeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAnnualvolumeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAnnualvolumeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioAnnualvolumeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioAnnualvolumeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioAnnualvolumeProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioAnnualvolumeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioAnnualvolumePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences))
        {
            Statecode = statecode;
            AdoxioVolumedestroyed = adoxioVolumedestroyed;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioDatesubmitted = adoxioDatesubmitted;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningteamValue = _owningteamValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioVolumeproduced = adoxioVolumeproduced;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            Versionnumber = versionnumber;
            AdoxioName = adoxioName;
            this._owninguserValue = _owninguserValue;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            Importsequencenumber = importsequencenumber;
            AdoxioAnnualvolumeid = adoxioAnnualvolumeid;
            AdoxioCalendaryear = adoxioCalendaryear;
            AdoxioCalendaryearint = adoxioCalendaryearint;
            Createdon = createdon;
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioAnnualvolumeSyncErrors = adoxioAnnualvolumeSyncErrors;
            AdoxioAnnualvolumeDuplicateMatchingRecord = adoxioAnnualvolumeDuplicateMatchingRecord;
            AdoxioAnnualvolumeDuplicateBaseRecord = adoxioAnnualvolumeDuplicateBaseRecord;
            AdoxioAnnualvolumeAsyncOperations = adoxioAnnualvolumeAsyncOperations;
            AdoxioAnnualvolumeMailboxTrackingFolders = adoxioAnnualvolumeMailboxTrackingFolders;
            AdoxioAnnualvolumeProcessSession = adoxioAnnualvolumeProcessSession;
            AdoxioAnnualvolumeBulkDeleteFailures = adoxioAnnualvolumeBulkDeleteFailures;
            AdoxioAnnualvolumePrincipalObjectAttributeAccesses = adoxioAnnualvolumePrincipalObjectAttributeAccesses;
            AdoxioApplication = adoxioApplication;
            AdoxioLicence = adoxioLicence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_volumedestroyed")]
        public int? AdoxioVolumedestroyed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_datesubmitted")]
        public System.DateTimeOffset? AdoxioDatesubmitted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_volumeproduced")]
        public int? AdoxioVolumeproduced { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolumeid")]
        public string AdoxioAnnualvolumeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_calendaryear")]
        public string AdoxioCalendaryear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_calendaryearint")]
        public int? AdoxioCalendaryearint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_annualvolume_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioAnnualvolumeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAnnualvolumeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAnnualvolumeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioAnnualvolumeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioAnnualvolumeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioAnnualvolumeProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioAnnualvolumeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualvolume_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioAnnualvolumePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

    }
}
