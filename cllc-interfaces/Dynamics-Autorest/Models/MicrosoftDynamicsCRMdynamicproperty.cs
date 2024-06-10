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
    /// Microsoft.Dynamics.CRM.dynamicproperty
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicproperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicproperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicproperty(string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string defaultvaluestring = default(string), int? importsequencenumber = default(int?), string _basedynamicpropertyidValue = default(string), bool? isreadonly = default(bool?), int? defaultvalueinteger = default(int?), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? maxvalueinteger = default(int?), decimal? maxvaluedouble = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string name = default(string), int? utcconversiontimezonecode = default(int?), string rootdynamicpropertyid = default(string), int? maxlengthstring = default(int?), decimal? maxvaluedecimal = default(decimal?), decimal? defaultvaluedouble = default(decimal?), decimal? minvaluedecimal = default(decimal?), string description = default(string), string _defaultvalueoptionsetValue = default(string), int? statuscode = default(int?), decimal? defaultvaluedecimal = default(decimal?), bool? ishidden = default(bool?), bool? isrequired = default(bool?), int? precision = default(int?), string dynamicpropertyid = default(string), int? dmtimportstate = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _regardingobjectidValue = default(string), int? minvalueinteger = default(int?), string versionnumber = default(string), string defaultattributevalue = default(string), decimal? minvaluedouble = default(decimal?), string overwrittendynamicpropertyid = default(string), int? datatype = default(int?), IList<MicrosoftDynamicsCRMsyncerror> dynamicpropertySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMteam> dynamicpropertyTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> dynamicpropertyAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> dynamicpropertyMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> dynamicpropertyBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> dynamicpropertyPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdynamicproperty basedynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), IList<MicrosoftDynamicsCRMdynamicproperty> dynamicpropertyBaseDynamicproperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> dynamicPropertyDynamicPropertyInstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMproductassociation regardingobjectidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMproduct regardingobjectidProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> dynamicpropertyDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> dynamicPropertyDynamicPropertyOptionSetItem = default(IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem>), MicrosoftDynamicsCRMdynamicpropertyoptionsetitem dynamicpropertyoptionsetvalueid = default(MicrosoftDynamicsCRMdynamicpropertyoptionsetitem), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Defaultvaluestring = defaultvaluestring;
            Importsequencenumber = importsequencenumber;
            this._basedynamicpropertyidValue = _basedynamicpropertyidValue;
            Isreadonly = isreadonly;
            Defaultvalueinteger = defaultvalueinteger;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Maxvalueinteger = maxvalueinteger;
            Maxvaluedouble = maxvaluedouble;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Name = name;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Rootdynamicpropertyid = rootdynamicpropertyid;
            Maxlengthstring = maxlengthstring;
            Maxvaluedecimal = maxvaluedecimal;
            Defaultvaluedouble = defaultvaluedouble;
            Minvaluedecimal = minvaluedecimal;
            Description = description;
            this._defaultvalueoptionsetValue = _defaultvalueoptionsetValue;
            Statuscode = statuscode;
            Defaultvaluedecimal = defaultvaluedecimal;
            Ishidden = ishidden;
            Isrequired = isrequired;
            Precision = precision;
            Dynamicpropertyid = dynamicpropertyid;
            Dmtimportstate = dmtimportstate;
            Modifiedon = modifiedon;
            this._regardingobjectidValue = _regardingobjectidValue;
            Minvalueinteger = minvalueinteger;
            Versionnumber = versionnumber;
            Defaultattributevalue = defaultattributevalue;
            Minvaluedouble = minvaluedouble;
            Overwrittendynamicpropertyid = overwrittendynamicpropertyid;
            Datatype = datatype;
            DynamicpropertySyncErrors = dynamicpropertySyncErrors;
            DynamicpropertyTeams = dynamicpropertyTeams;
            DynamicpropertyAsyncOperations = dynamicpropertyAsyncOperations;
            DynamicpropertyMailboxTrackingFolders = dynamicpropertyMailboxTrackingFolders;
            DynamicpropertyBulkDeleteFailures = dynamicpropertyBulkDeleteFailures;
            DynamicpropertyPrincipalObjectAttributeAccesses = dynamicpropertyPrincipalObjectAttributeAccesses;
            Createdonbehalfby = createdonbehalfby;
            Basedynamicpropertyid = basedynamicpropertyid;
            DynamicpropertyBaseDynamicproperty = dynamicpropertyBaseDynamicproperty;
            DynamicPropertyDynamicPropertyInstance = dynamicPropertyDynamicPropertyInstance;
            Createdby = createdby;
            RegardingobjectidProductassociation = regardingobjectidProductassociation;
            RegardingobjectidProduct = regardingobjectidProduct;
            Modifiedonbehalfby = modifiedonbehalfby;
            DynamicpropertyDynamicPropertyAssociation = dynamicpropertyDynamicPropertyAssociation;
            Organizationid = organizationid;
            DynamicPropertyDynamicPropertyOptionSetItem = dynamicPropertyDynamicPropertyOptionSetItem;
            Dynamicpropertyoptionsetvalueid = dynamicpropertyoptionsetvalueid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluestring")]
        public string Defaultvaluestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_basedynamicpropertyid_value")]
        public string _basedynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isreadonly")]
        public bool? Isreadonly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvalueinteger")]
        public int? Defaultvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvalueinteger")]
        public int? Maxvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvaluedouble")]
        public decimal? Maxvaluedouble { get; set; }

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
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "rootdynamicpropertyid")]
        public string Rootdynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxlengthstring")]
        public int? Maxlengthstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvaluedecimal")]
        public decimal? Maxvaluedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluedouble")]
        public decimal? Defaultvaluedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvaluedecimal")]
        public decimal? Minvaluedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultvalueoptionset_value")]
        public string _defaultvalueoptionsetValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluedecimal")]
        public decimal? Defaultvaluedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public bool? Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrequired")]
        public bool? Isrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public string Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvalueinteger")]
        public int? Minvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultattributevalue")]
        public string Defaultattributevalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvaluedouble")]
        public decimal? Minvaluedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwrittendynamicpropertyid")]
        public string Overwrittendynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datatype")]
        public int? Datatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DynamicpropertySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_Teams")]
        public IList<MicrosoftDynamicsCRMteam> DynamicpropertyTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DynamicpropertyAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DynamicpropertyMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DynamicpropertyBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DynamicpropertyPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "basedynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Basedynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_base_dynamicproperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> DynamicpropertyBaseDynamicproperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DynamicProperty_DynamicPropertyInstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> DynamicPropertyDynamicPropertyInstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation RegardingobjectidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_product")]
        public MicrosoftDynamicsCRMproduct RegardingobjectidProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Dynamicproperty_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> DynamicpropertyDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DynamicProperty_DynamicPropertyOptionSetItem")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> DynamicPropertyDynamicPropertyOptionSetItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvalueid")]
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem Dynamicpropertyoptionsetvalueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
