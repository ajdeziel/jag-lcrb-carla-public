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

    public partial class MicrosoftDynamicsCRMuserform
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserform
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuserform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserform
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuserform(string userformid = default(string), string formxml = default(string), string _owneridValue = default(string), string objecttypecode = default(string), string _createdonbehalfbyValue = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), int? type = default(int?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), object modifiedon = default(object), bool? istabletenabled = default(bool?), string description = default(string), string name = default(string), object createdon = default(object), string versionnumber = default(string), string _owninguserValue = default(string), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMasyncoperation> userFormAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMbulkdeletefailure> userFormBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit))
        {
            Userformid = userformid;
            Formxml = formxml;
            this._owneridValue = _owneridValue;
            Objecttypecode = objecttypecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Type = type;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Istabletenabled = istabletenabled;
            Description = description;
            Name = name;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Owninguser = owninguser;
            Owningteam = owningteam;
            UserFormAsyncOperations = userFormAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            UserFormBulkDeleteFailures = userFormBulkDeleteFailures;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userformid")]
        public string Userformid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formxml")]
        public string Formxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

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
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istabletenabled")]
        public bool? Istabletenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

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
        [JsonProperty(PropertyName = "UserForm_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UserFormAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserForm_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UserFormBulkDeleteFailures { get; set; }

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
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

    }
}
