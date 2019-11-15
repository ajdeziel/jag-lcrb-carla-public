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
    /// Microsoft.Dynamics.CRM.letter
    /// </summary>
    public partial class MicrosoftDynamicsCRMletter
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        public MicrosoftDynamicsCRMletter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        /// <param name="category">Type a category to identify the letter type,
        /// such as sales offer or past due notice, to tie the letter to a
        /// business group or function.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="address">Type the complete recipient address for the
        /// letter to ensure timely delivery.</param>
        /// <param name="directioncode">Select the direction of the letter as
        /// incoming or outbound.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="subcategory">Type a subcategory to identify the letter
        /// type and relate the activity to a specific product, sales region,
        /// business group, or other function.</param>
        /// <param name="subscriptionid">For internal use only.</param>
        public MicrosoftDynamicsCRMletter(string category = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string address = default(string), bool? directioncode = default(bool?), int? importsequencenumber = default(int?), string subcategory = default(string), string subscriptionid = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementLetter = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateLetter = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingLetter = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderLetter = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordLetter = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMactioncard> letterActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceLetter = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMcampaignresponse> letterCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignLetter = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> letterConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMbulkdeletefailure> letterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMquote regardingobjectidQuoteLetter = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleLetter = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMsyncerror> letterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitLetter = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMannotation> letterAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceLetter = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMsla slainvokedidLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderLetter = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMteam owningteamLetter = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityLetter = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMactivityparty> letterActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMservice serviceidLetter = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMasyncoperation> letterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMcontract regardingobjectidContractLetter = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidLetter = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationLetter = default(MicrosoftDynamicsCRMbulkoperation), IList<MicrosoftDynamicsCRMconnection> letterConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguserLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityLetter = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMqueueitem> letterQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMincident regardingobjectidIncidentLetter = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsystemuser modifiedbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLeadLetter = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMsla slaLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMaccount regardingobjectidAccountLetter = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact regardingobjectidContactLetter = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessLetter = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationLetter = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintLetter = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationLetter = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesLetter = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerLetter = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationLetter = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation))
        {
            Category = category;
            Overriddencreatedon = overriddencreatedon;
            Address = address;
            Directioncode = directioncode;
            Importsequencenumber = importsequencenumber;
            Subcategory = subcategory;
            Subscriptionid = subscriptionid;
            RegardingobjectidEntitlementLetter = regardingobjectidEntitlementLetter;
            RegardingobjectidEntitlementtemplateLetter = regardingobjectidEntitlementtemplateLetter;
            RegardingobjectidBookableresourcebookingLetter = regardingobjectidBookableresourcebookingLetter;
            RegardingobjectidBookableresourcebookingheaderLetter = regardingobjectidBookableresourcebookingheaderLetter;
            RegardingobjectidKnowledgebaserecordLetter = regardingobjectidKnowledgebaserecordLetter;
            LetterActioncard = letterActioncard;
            SlakpiinstanceLetter = slakpiinstanceLetter;
            LetterCampaignresponse = letterCampaignresponse;
            RegardingobjectidCampaignLetter = regardingobjectidCampaignLetter;
            StageidProcessstage = stageidProcessstage;
            ModifiedonbehalfbyLetter = modifiedonbehalfbyLetter;
            CreatedonbehalfbyLetter = createdonbehalfbyLetter;
            LetterConnections2 = letterConnections2;
            LetterBulkDeleteFailures = letterBulkDeleteFailures;
            RegardingobjectidQuoteLetter = regardingobjectidQuoteLetter;
            RegardingobjectidKnowledgearticleLetter = regardingobjectidKnowledgearticleLetter;
            LetterSyncErrors = letterSyncErrors;
            OwningbusinessunitLetter = owningbusinessunitLetter;
            LetterAnnotation = letterAnnotation;
            RegardingobjectidInvoiceLetter = regardingobjectidInvoiceLetter;
            SlainvokedidLetterSla = slainvokedidLetterSla;
            RegardingobjectidSalesorderLetter = regardingobjectidSalesorderLetter;
            OwningteamLetter = owningteamLetter;
            RegardingobjectidCampaignactivityLetter = regardingobjectidCampaignactivityLetter;
            LetterActivityParties = letterActivityParties;
            ServiceidLetter = serviceidLetter;
            LetterAsyncOperations = letterAsyncOperations;
            RegardingobjectidContractLetter = regardingobjectidContractLetter;
            TransactioncurrencyidLetter = transactioncurrencyidLetter;
            RegardingobjectidBulkoperationLetter = regardingobjectidBulkoperationLetter;
            LetterConnections1 = letterConnections1;
            OwninguserLetter = owninguserLetter;
            LetterDuplicateBaseRecord = letterDuplicateBaseRecord;
            RegardingobjectidOpportunityLetter = regardingobjectidOpportunityLetter;
            LetterQueueItem = letterQueueItem;
            ActivityidActivitypointer = activityidActivitypointer;
            RegardingobjectidIncidentLetter = regardingobjectidIncidentLetter;
            ModifiedbyLetter = modifiedbyLetter;
            RegardingobjectidLeadLetter = regardingobjectidLeadLetter;
            SlaLetterSla = slaLetterSla;
            CreatedbyLetter = createdbyLetter;
            LetterDuplicateMatchingRecord = letterDuplicateMatchingRecord;
            RegardingobjectidAccountLetter = regardingobjectidAccountLetter;
            RegardingobjectidContactLetter = regardingobjectidContactLetter;
            RegardingobjectidAbsScheduledprocessLetter = regardingobjectidAbsScheduledprocessLetter;
            RegardingobjectidAdoxioApplicationLetter = regardingobjectidAdoxioApplicationLetter;
            RegardingobjectidAdoxioComplaintLetter = regardingobjectidAdoxioComplaintLetter;
            RegardingobjectidAdoxioInvestigationLetter = regardingobjectidAdoxioInvestigationLetter;
            RegardingobjectidAdoxioLicencesLetter = regardingobjectidAdoxioLicencesLetter;
            RegardingobjectidAdoxioWorkerLetter = regardingobjectidAdoxioWorkerLetter;
            RegardingobjectidAdoxioComplianceinvestigationLetter = regardingobjectidAdoxioComplianceinvestigationLetter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type a category to identify the letter type, such as
        /// sales offer or past due notice, to tie the letter to a business
        /// group or function.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets type the complete recipient address for the letter to
        /// ensure timely delivery.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets select the direction of the letter as incoming or
        /// outbound.
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets type a subcategory to identify the letter type and
        /// relate the activity to a specific product, sales region, business
        /// group, or other function.
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_letter")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_letter")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_letter")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_letter")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_letter")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> LetterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_letter")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> LetterCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_letter")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> LetterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_letter")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_letter")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LetterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_letter")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> LetterAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_letter")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_letter_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_letter")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_letter")]
        public MicrosoftDynamicsCRMteam OwningteamLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_letter")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> LetterActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_letter")]
        public MicrosoftDynamicsCRMservice ServiceidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LetterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_letter")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_letter")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_letter")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_letter")]
        public MicrosoftDynamicsCRMsystemuser OwninguserLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_letter")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> LetterQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_letter")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_letter")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_letter_sla")]
        public MicrosoftDynamicsCRMsla SlaLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_letter")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_letter")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_letter")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_letter")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_letter")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_letter")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_letter")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_letter")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_letter")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationLetter { get; set; }

    }
}
