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
    /// Microsoft.Dynamics.CRM.adoxio_fundingsource
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioFundingsource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFundingsource class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioFundingsource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFundingsource class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioFundingsource(int? utcconversiontimezonecode = default(int?), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), string _createdbyValue = default(string), string adoxioFundingsourceid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), decimal? adoxioAmountoffundingBase = default(decimal?), int? timezoneruleversionnumber = default(int?), string _owningteamValue = default(string), string versionnumber = default(string), decimal? adoxioAmountoffunding = default(decimal?), int? statuscode = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? exchangerate = default(decimal?), string _transactioncurrencyidValue = default(string), string _adoxioAccountidValue = default(string), string adoxioName = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioFundingsourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFundingsourceDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFundingsourceDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioFundingsourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioFundingsourceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioFundingsourceProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioFundingsourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioFundingsourcePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            this._owneridValue = _owneridValue;
            this._createdbyValue = _createdbyValue;
            AdoxioFundingsourceid = adoxioFundingsourceid;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            AdoxioAmountoffundingBase = adoxioAmountoffundingBase;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningteamValue = _owningteamValue;
            Versionnumber = versionnumber;
            AdoxioAmountoffunding = adoxioAmountoffunding;
            Statuscode = statuscode;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            Exchangerate = exchangerate;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            AdoxioName = adoxioName;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioFundingsourceSyncErrors = adoxioFundingsourceSyncErrors;
            AdoxioFundingsourceDuplicateMatchingRecord = adoxioFundingsourceDuplicateMatchingRecord;
            AdoxioFundingsourceDuplicateBaseRecord = adoxioFundingsourceDuplicateBaseRecord;
            AdoxioFundingsourceAsyncOperations = adoxioFundingsourceAsyncOperations;
            AdoxioFundingsourceMailboxTrackingFolders = adoxioFundingsourceMailboxTrackingFolders;
            AdoxioFundingsourceProcessSession = adoxioFundingsourceProcessSession;
            AdoxioFundingsourceBulkDeleteFailures = adoxioFundingsourceBulkDeleteFailures;
            AdoxioFundingsourcePrincipalObjectAttributeAccesses = adoxioFundingsourcePrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioAccountId = adoxioAccountId;
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
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsourceid")]
        public string AdoxioFundingsourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amountoffunding_base")]
        public decimal? AdoxioAmountoffundingBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amountoffunding")]
        public decimal? AdoxioAmountoffunding { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_fundingsource_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioFundingsourceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFundingsourceDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFundingsourceDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioFundingsourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioFundingsourceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioFundingsourceProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioFundingsourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fundingsource_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioFundingsourcePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

    }
}
