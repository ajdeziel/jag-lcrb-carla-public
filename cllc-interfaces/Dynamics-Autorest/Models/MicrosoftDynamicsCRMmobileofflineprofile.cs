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
    /// Microsoft.Dynamics.CRM.mobileofflineprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMmobileofflineprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofile(string _organizationidValue = default(string), string versionnumber = default(string), string mobileofflineprofileid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string mobileofflineprofileidunique = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), bool? isvalidated = default(bool?), string _modifiedonbehalfbyValue = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string processid = default(string), string solutionid = default(string), string description = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string introducedversion = default(string), string stageid = default(string), string name = default(string), string selectedentitymetadata = default(string), string traversedpath = default(string), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMorganization> defaultMobileOfflineProfileOrganization = default(IList<MicrosoftDynamicsCRMorganization>), IList<MicrosoftDynamicsCRMmobileofflineprofileitem> mobileOfflineProfileMobileOfflineProfileItem = default(IList<MicrosoftDynamicsCRMmobileofflineprofileitem>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsystemuser> mobileOfflineProfileSystemUser = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            Mobileofflineprofileid = mobileofflineprofileid;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Mobileofflineprofileidunique = mobileofflineprofileidunique;
            Overwritetime = overwritetime;
            this._modifiedbyValue = _modifiedbyValue;
            Isvalidated = isvalidated;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Ismanaged = ismanaged;
            Publishedon = publishedon;
            Processid = processid;
            Solutionid = solutionid;
            Description = description;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Introducedversion = introducedversion;
            Stageid = stageid;
            Name = name;
            Selectedentitymetadata = selectedentitymetadata;
            Traversedpath = traversedpath;
            Componentstate = componentstate;
            Modifiedonbehalfby = modifiedonbehalfby;
            DefaultMobileOfflineProfileOrganization = defaultMobileOfflineProfileOrganization;
            MobileOfflineProfileMobileOfflineProfileItem = mobileOfflineProfileMobileOfflineProfileItem;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            MobileOfflineProfileSystemUser = mobileOfflineProfileSystemUser;
            Createdonbehalfby = createdonbehalfby;
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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileid")]
        public string Mobileofflineprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileidunique")]
        public string Mobileofflineprofileidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvalidated")]
        public bool? Isvalidated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectedentitymetadata")]
        public string Selectedentitymetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultMobileOfflineProfile_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> DefaultMobileOfflineProfileOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_MobileOfflineProfileItem")]
        public IList<MicrosoftDynamicsCRMmobileofflineprofileitem> MobileOfflineProfileMobileOfflineProfileItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_SystemUser")]
        public IList<MicrosoftDynamicsCRMsystemuser> MobileOfflineProfileSystemUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
