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
    /// Microsoft.Dynamics.CRM.appmodule
    /// </summary>
    public partial class MicrosoftDynamicsCRMappmodule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappmodule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappmodule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappmodule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappmodule(string appmodulexmlmanaged = default(string), string webresourceid = default(string), string uniquename = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string url = default(string), string appmoduleversion = default(string), string appmoduleidunique = default(string), int? clienttype = default(int?), string _modifiedonbehalfbyValue = default(string), string solutionid = default(string), bool? isdefault = default(bool?), int? navigationtype = default(int?), string versionnumber = default(string), bool? isfeatured = default(bool?), string _publisheridValue = default(string), bool? ismanaged = default(bool?), int? formfactor = default(int?), string _modifiedbyValue = default(string), int? statuscode = default(int?), string introducedversion = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string welcomepageid = default(string), int? statecode = default(int?), string name = default(string), string _createdonbehalfbyValue = default(string), string appmoduleid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? componentstate = default(int?), string description = default(string), string configxml = default(string), string eventhandlers = default(string), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string optimizedfor = default(string), string _createdbyValue = default(string), string _organizationidValue = default(string), int? importsequencenumber = default(int?), string descriptor = default(string), IList<MicrosoftDynamicsCRMrole> appmodulerolesAssociation = default(IList<MicrosoftDynamicsCRMrole>), MicrosoftDynamicsCRMsystemuser appmoduleModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMappconfig> appmoduleAppconfig = default(IList<MicrosoftDynamicsCRMappconfig>), MicrosoftDynamicsCRMsystemuser appmoduleCreatedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMpublisher publisherAppmoduleAppmodule = default(MicrosoftDynamicsCRMpublisher), IList<MicrosoftDynamicsCRMappmodulecomponent> appmoduleAppmodulecomponent = default(IList<MicrosoftDynamicsCRMappmodulecomponent>), MicrosoftDynamicsCRMsystemuser appmoduleModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser appmoduleCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationAppmoduleAppmodule = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMserviceplan> serviceplanAppmoduleAssociation = default(IList<MicrosoftDynamicsCRMserviceplan>))
        {
            Appmodulexmlmanaged = appmodulexmlmanaged;
            Webresourceid = webresourceid;
            Uniquename = uniquename;
            Createdon = createdon;
            Overwritetime = overwritetime;
            Url = url;
            Appmoduleversion = appmoduleversion;
            Appmoduleidunique = appmoduleidunique;
            Clienttype = clienttype;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Solutionid = solutionid;
            Isdefault = isdefault;
            Navigationtype = navigationtype;
            Versionnumber = versionnumber;
            Isfeatured = isfeatured;
            this._publisheridValue = _publisheridValue;
            Ismanaged = ismanaged;
            Formfactor = formfactor;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Introducedversion = introducedversion;
            Modifiedon = modifiedon;
            Welcomepageid = welcomepageid;
            Statecode = statecode;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Appmoduleid = appmoduleid;
            Overriddencreatedon = overriddencreatedon;
            Componentstate = componentstate;
            Description = description;
            Configxml = configxml;
            Eventhandlers = eventhandlers;
            Publishedon = publishedon;
            Optimizedfor = optimizedfor;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            Importsequencenumber = importsequencenumber;
            Descriptor = descriptor;
            AppmodulerolesAssociation = appmodulerolesAssociation;
            AppmoduleModifiedonbehalfby = appmoduleModifiedonbehalfby;
            AppmoduleAppconfig = appmoduleAppconfig;
            AppmoduleCreatedby = appmoduleCreatedby;
            PublisherAppmoduleAppmodule = publisherAppmoduleAppmodule;
            AppmoduleAppmodulecomponent = appmoduleAppmodulecomponent;
            AppmoduleModifiedby = appmoduleModifiedby;
            AppmoduleCreatedonbehalfby = appmoduleCreatedonbehalfby;
            OrganizationAppmoduleAppmodule = organizationAppmoduleAppmodule;
            ServiceplanAppmoduleAssociation = serviceplanAppmoduleAssociation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodulexmlmanaged")]
        public string Appmodulexmlmanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public string Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleversion")]
        public string Appmoduleversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleidunique")]
        public string Appmoduleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clienttype")]
        public int? Clienttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navigationtype")]
        public int? Navigationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isfeatured")]
        public bool? Isfeatured { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_publisherid_value")]
        public string _publisheridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formfactor")]
        public int? Formfactor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "welcomepageid")]
        public string Welcomepageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleid")]
        public string Appmoduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configxml")]
        public string Configxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eventhandlers")]
        public string Eventhandlers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "optimizedfor")]
        public string Optimizedfor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "descriptor")]
        public string Descriptor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleroles_association")]
        public IList<MicrosoftDynamicsCRMrole> AppmodulerolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppmoduleModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_appconfig")]
        public IList<MicrosoftDynamicsCRMappconfig> AppmoduleAppconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_createdby")]
        public MicrosoftDynamicsCRMsystemuser AppmoduleCreatedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publisher_appmodule_appmodule")]
        public MicrosoftDynamicsCRMpublisher PublisherAppmoduleAppmodule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_appmodulecomponent")]
        public IList<MicrosoftDynamicsCRMappmodulecomponent> AppmoduleAppmodulecomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser AppmoduleModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppmoduleCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_appmodule_appmodule")]
        public MicrosoftDynamicsCRMorganization OrganizationAppmoduleAppmodule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceplan_appmodule_association")]
        public IList<MicrosoftDynamicsCRMserviceplan> ServiceplanAppmoduleAssociation { get; set; }

    }
}
