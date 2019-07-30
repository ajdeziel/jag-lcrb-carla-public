// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// workflowlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMworkflowlog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowlog(string stepname = default(string), string _childworkflowinstanceidValue = default(string), string _owneridValue = default(string), string message = default(string), int? duration = default(int?), string activityname = default(string), string _owningbusinessunitValue = default(string), string interactionactivityresult = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string workflowlogid = default(string), string stagename = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), int? status = default(int?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), string description = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? startedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _asyncoperationidValue = default(string), int? errorcode = default(int?), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMasyncoperation childworkflowinstanceidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMleadtoopportunitysalesprocess leadToOpportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMleadtoopportunitysalesprocess), MicrosoftDynamicsCRMexpiredprocess expiredProcessAsyncoperationid = default(MicrosoftDynamicsCRMexpiredprocess), MicrosoftDynamicsCRMtranslationprocess translationProcessAsyncoperationid = default(MicrosoftDynamicsCRMtranslationprocess), MicrosoftDynamicsCRMopportunitysalesprocess opportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMopportunitysalesprocess), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMphonetocaseprocess phoneToCaseProcessAsyncoperationid = default(MicrosoftDynamicsCRMphonetocaseprocess), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMasyncoperation asyncoperationidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMnewprocess newProcessAsyncoperationid = default(MicrosoftDynamicsCRMnewprocess), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2 asyncoperationidAdoxioApplicationbpfmvpv2 = default(MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2), MicrosoftDynamicsCRMadoxioComplaintpublicbpf asyncoperationidAdoxioComplaintpublicbpf = default(MicrosoftDynamicsCRMadoxioComplaintpublicbpf), MicrosoftDynamicsCRMadoxioApplicationbpfv3 asyncoperationidAdoxioApplicationbpfv3 = default(MicrosoftDynamicsCRMadoxioApplicationbpfv3))
        {
            Stepname = stepname;
            this._childworkflowinstanceidValue = _childworkflowinstanceidValue;
            this._owneridValue = _owneridValue;
            Message = message;
            Duration = duration;
            Activityname = activityname;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Interactionactivityresult = interactionactivityresult;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Completedon = completedon;
            Workflowlogid = workflowlogid;
            Stagename = stagename;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Status = status;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Description = description;
            this._regardingobjectidValue = _regardingobjectidValue;
            Modifiedon = modifiedon;
            Startedon = startedon;
            Createdon = createdon;
            this._asyncoperationidValue = _asyncoperationidValue;
            Errorcode = errorcode;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            ChildworkflowinstanceidAsyncoperation = childworkflowinstanceidAsyncoperation;
            LeadToOpportunitySalesProcessAsyncoperationid = leadToOpportunitySalesProcessAsyncoperationid;
            ExpiredProcessAsyncoperationid = expiredProcessAsyncoperationid;
            TranslationProcessAsyncoperationid = translationProcessAsyncoperationid;
            OpportunitySalesProcessAsyncoperationid = opportunitySalesProcessAsyncoperationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            PhoneToCaseProcessAsyncoperationid = phoneToCaseProcessAsyncoperationid;
            Owningbusinessunit = owningbusinessunit;
            AsyncoperationidAsyncoperation = asyncoperationidAsyncoperation;
            NewProcessAsyncoperationid = newProcessAsyncoperationid;
            Createdby = createdby;
            AsyncoperationidAdoxioApplicationbpfmvpv2 = asyncoperationidAdoxioApplicationbpfmvpv2;
            AsyncoperationidAdoxioComplaintpublicbpf = asyncoperationidAdoxioComplaintpublicbpf;
            AsyncoperationidAdoxioApplicationbpfv3 = asyncoperationidAdoxioApplicationbpfv3;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stepname")]
        public string Stepname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_childworkflowinstanceid_value")]
        public string _childworkflowinstanceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityname")]
        public string Activityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interactionactivityresult")]
        public string Interactionactivityresult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogid")]
        public string Workflowlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startedon")]
        public System.DateTimeOffset? Startedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_asyncoperationid_value")]
        public string _asyncoperationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorcode")]
        public int? Errorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childworkflowinstanceid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation ChildworkflowinstanceidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadToOpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess LeadToOpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExpiredProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMexpiredprocess ExpiredProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMtranslationprocess TranslationProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMopportunitysalesprocess OpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneToCaseProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMphonetocaseprocess PhoneToCaseProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation AsyncoperationidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMnewprocess NewProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_adoxio_applicationbpfmvpv2")]
        public MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2 AsyncoperationidAdoxioApplicationbpfmvpv2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_adoxio_complaintpublicbpf")]
        public MicrosoftDynamicsCRMadoxioComplaintpublicbpf AsyncoperationidAdoxioComplaintpublicbpf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_adoxio_applicationbpfv3")]
        public MicrosoftDynamicsCRMadoxioApplicationbpfv3 AsyncoperationidAdoxioApplicationbpfv3 { get; set; }

    }
}
