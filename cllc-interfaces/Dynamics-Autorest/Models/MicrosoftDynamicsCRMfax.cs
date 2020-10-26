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
    /// Microsoft.Dynamics.CRM.fax
    /// </summary>
    public partial class MicrosoftDynamicsCRMfax
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfax class.
        /// </summary>
        public MicrosoftDynamicsCRMfax()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfax class.
        /// </summary>
        public MicrosoftDynamicsCRMfax(string tsid = default(string), int? numberofpages = default(int?), string coverpagename = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string subcategory = default(string), string subscriptionid = default(string), int? importsequencenumber = default(int?), bool? directioncode = default(bool?), string faxnumber = default(string), string billingcode = default(string), string category = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementFax = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateFax = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingFax = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderFax = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordFax = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumFax = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessFax = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationFax = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintFax = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationFax = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesFax = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerFax = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationFax = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsite regardingobjectidSiteFax = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventFax = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioEnforcementaction regardingobjectidAdoxioEnforcementactionFax = default(MicrosoftDynamicsCRMadoxioEnforcementaction), MicrosoftDynamicsCRMadoxioSpecialevent regardingobjectidAdoxioSpecialeventFax = default(MicrosoftDynamicsCRMadoxioSpecialevent), IList<MicrosoftDynamicsCRMbulkdeletefailure> faxBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMcampaignresponse> faxCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityFax = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMbusinessunit owningbusinessunitFax = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMaccount regardingobjectidAccountFax = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMannotation> faxAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMservice serviceidFax = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMactioncard> faxActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMsystemuser createdbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLeadFax = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidFax = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMteam owningteamFax = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMduplicaterecord> faxDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleFax = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser owninguserFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaFaxSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMqueueitem> faxQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMactivityparty> faxActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> faxPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser modifiedbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyFax = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMconnection> faxConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsla slainvokedidFaxSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityFax = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationFax = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceFax = default(MicrosoftDynamicsCRMinvoice), IList<MicrosoftDynamicsCRMprocesssession> faxProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMcontact regardingobjectidContactFax = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceFax = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMquote regardingobjectidQuoteFax = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignFax = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMconnection> faxConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMcontract regardingobjectidContractFax = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMsyncerror> faxSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> faxDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderFax = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMincident regardingobjectidIncidentFax = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMasyncoperation> faxAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Tsid = tsid;
            Numberofpages = numberofpages;
            Coverpagename = coverpagename;
            Overriddencreatedon = overriddencreatedon;
            Subcategory = subcategory;
            Subscriptionid = subscriptionid;
            Importsequencenumber = importsequencenumber;
            Directioncode = directioncode;
            Faxnumber = faxnumber;
            Billingcode = billingcode;
            Category = category;
            RegardingobjectidEntitlementFax = regardingobjectidEntitlementFax;
            RegardingobjectidEntitlementtemplateFax = regardingobjectidEntitlementtemplateFax;
            RegardingobjectidBookableresourcebookingFax = regardingobjectidBookableresourcebookingFax;
            RegardingobjectidBookableresourcebookingheaderFax = regardingobjectidBookableresourcebookingheaderFax;
            RegardingobjectidKnowledgebaserecordFax = regardingobjectidKnowledgebaserecordFax;
            RegardingobjectidMsdynPostalbumFax = regardingobjectidMsdynPostalbumFax;
            RegardingobjectidAbsScheduledprocessFax = regardingobjectidAbsScheduledprocessFax;
            RegardingobjectidAdoxioApplicationFax = regardingobjectidAdoxioApplicationFax;
            RegardingobjectidAdoxioComplaintFax = regardingobjectidAdoxioComplaintFax;
            RegardingobjectidAdoxioInvestigationFax = regardingobjectidAdoxioInvestigationFax;
            RegardingobjectidAdoxioLicencesFax = regardingobjectidAdoxioLicencesFax;
            RegardingobjectidAdoxioWorkerFax = regardingobjectidAdoxioWorkerFax;
            RegardingobjectidAdoxioComplianceinvestigationFax = regardingobjectidAdoxioComplianceinvestigationFax;
            RegardingobjectidSiteFax = regardingobjectidSiteFax;
            RegardingobjectidAdoxioEventFax = regardingobjectidAdoxioEventFax;
            RegardingobjectidAdoxioEnforcementactionFax = regardingobjectidAdoxioEnforcementactionFax;
            RegardingobjectidAdoxioSpecialeventFax = regardingobjectidAdoxioSpecialeventFax;
            FaxBulkDeleteFailures = faxBulkDeleteFailures;
            FaxCampaignresponse = faxCampaignresponse;
            StageidProcessstage = stageidProcessstage;
            RegardingobjectidOpportunityFax = regardingobjectidOpportunityFax;
            OwningbusinessunitFax = owningbusinessunitFax;
            RegardingobjectidAccountFax = regardingobjectidAccountFax;
            FaxAnnotation = faxAnnotation;
            ServiceidFax = serviceidFax;
            FaxActioncard = faxActioncard;
            CreatedbyFax = createdbyFax;
            CreatedonbehalfbyFax = createdonbehalfbyFax;
            RegardingobjectidLeadFax = regardingobjectidLeadFax;
            TransactioncurrencyidFax = transactioncurrencyidFax;
            OwningteamFax = owningteamFax;
            FaxDuplicateMatchingRecord = faxDuplicateMatchingRecord;
            RegardingobjectidKnowledgearticleFax = regardingobjectidKnowledgearticleFax;
            OwninguserFax = owninguserFax;
            SlaFaxSla = slaFaxSla;
            FaxQueueItem = faxQueueItem;
            FaxActivityParties = faxActivityParties;
            FaxPrincipalobjectattributeaccess = faxPrincipalobjectattributeaccess;
            ModifiedbyFax = modifiedbyFax;
            ModifiedonbehalfbyFax = modifiedonbehalfbyFax;
            ActivityidActivitypointer = activityidActivitypointer;
            FaxConnections2 = faxConnections2;
            SlainvokedidFaxSla = slainvokedidFaxSla;
            RegardingobjectidCampaignactivityFax = regardingobjectidCampaignactivityFax;
            RegardingobjectidBulkoperationFax = regardingobjectidBulkoperationFax;
            RegardingobjectidInvoiceFax = regardingobjectidInvoiceFax;
            FaxProcessSessions = faxProcessSessions;
            RegardingobjectidContactFax = regardingobjectidContactFax;
            SlakpiinstanceFax = slakpiinstanceFax;
            RegardingobjectidQuoteFax = regardingobjectidQuoteFax;
            RegardingobjectidCampaignFax = regardingobjectidCampaignFax;
            FaxConnections1 = faxConnections1;
            RegardingobjectidContractFax = regardingobjectidContractFax;
            FaxSyncErrors = faxSyncErrors;
            FaxDuplicateBaseRecord = faxDuplicateBaseRecord;
            RegardingobjectidSalesorderFax = regardingobjectidSalesorderFax;
            RegardingobjectidIncidentFax = regardingobjectidIncidentFax;
            FaxAsyncOperations = faxAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tsid")]
        public string Tsid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberofpages")]
        public int? Numberofpages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coverpagename")]
        public string Coverpagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faxnumber")]
        public string Faxnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcode")]
        public string Billingcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_fax")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_fax")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_fax")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_fax")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_fax")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_fax")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_fax")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_fax")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_fax")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_fax")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_fax")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_fax")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_fax")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_fax")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_fax")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_enforcementaction_fax")]
        public MicrosoftDynamicsCRMadoxioEnforcementaction RegardingobjectidAdoxioEnforcementactionFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_specialevent_fax")]
        public MicrosoftDynamicsCRMadoxioSpecialevent RegardingobjectidAdoxioSpecialeventFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FaxBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> FaxCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_fax")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_fax")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_fax")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> FaxAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_fax")]
        public MicrosoftDynamicsCRMservice ServiceidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> FaxActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_fax")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_fax")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_fax")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_fax")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_fax")]
        public MicrosoftDynamicsCRMteam OwningteamFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> FaxDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_fax")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_fax")]
        public MicrosoftDynamicsCRMsystemuser OwninguserFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_fax_sla")]
        public MicrosoftDynamicsCRMsla SlaFaxSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> FaxQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> FaxActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> FaxPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_fax")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_fax")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> FaxConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_fax_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidFaxSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_fax")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_fax")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_fax")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> FaxProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_fax")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_fax")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_fax")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_fax")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> FaxConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_fax")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FaxSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> FaxDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_fax")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_fax")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Fax_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FaxAsyncOperations { get; set; }

    }
}
