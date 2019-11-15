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
    /// Microsoft.Dynamics.CRM.productpricelevel
    /// </summary>
    public partial class MicrosoftDynamicsCRMproductpricelevel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductpricelevel class.
        /// </summary>
        public MicrosoftDynamicsCRMproductpricelevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductpricelevel class.
        /// </summary>
        /// <param name="quantitysellingcode">Quantity of the product that must
        /// be sold for a given price level.</param>
        /// <param name="processid">Unique identifier of the Process.</param>
        /// <param name="stageid">Shows the ID of the stage.</param>
        /// <param name="roundingoptioncode">Option for rounding the price
        /// list.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_uomidValue">Unique identifier of the unit for the
        /// price list.</param>
        /// <param name="productnumber">User-defined product number.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="versionnumber">Version number of the price
        /// list.</param>
        /// <param name="productpricelevelid">Unique identifier of the price
        /// list.</param>
        /// <param name="pricingmethodcode">Pricing method applied to the price
        /// list.</param>
        /// <param name="modifiedon">Date and time when the price list was last
        /// modified.</param>
        /// <param name="_discounttypeidValue">Unique identifier of the
        /// discount list associated with the price list.</param>
        /// <param name="_uomscheduleidValue">Unique identifier of the unit
        /// schedule for the price list.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="organizationid">Unique identifier of the organization
        /// associated with the price list.</param>
        /// <param name="amount">Monetary amount for the price list.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the price list.</param>
        /// <param name="_productidValue">Product associated with the price
        /// list.</param>
        /// <param name="roundingpolicycode">Policy for rounding the price
        /// list.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the price list.</param>
        /// <param name="createdon">Date and time when the price list was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="amountBase">Shows the Amount field converted to the
        /// system's default base currency, if specified as a fixed amount. The
        /// calculation uses the exchange rate specified in the Currencies
        /// area.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who last updated the
        /// record on behalf of another user.</param>
        /// <param name="_pricelevelidValue">Unique identifier of the price
        /// level associated with this price list.</param>
        /// <param name="percentage">Percentage for the price list.</param>
        /// <param name="roundingoptionamount">Rounding option amount for the
        /// price list.</param>
        /// <param name="roundingoptionamountBase">Shows the Rounding Amount
        /// field converted to the system's default base currency for reporting
        /// purposes. The calculations use the exchange rate specified in the
        /// Currencies area.</param>
        /// <param name="traversedpath">For internal use only.</param>
        public MicrosoftDynamicsCRMproductpricelevel(int? quantitysellingcode = default(int?), string processid = default(string), string stageid = default(string), int? roundingoptioncode = default(int?), decimal? exchangerate = default(decimal?), string _uomidValue = default(string), string productnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), string productpricelevelid = default(string), int? pricingmethodcode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _discounttypeidValue = default(string), string _uomscheduleidValue = default(string), string _transactioncurrencyidValue = default(string), string organizationid = default(string), decimal? amount = default(decimal?), string _createdbyValue = default(string), string _productidValue = default(string), int? roundingpolicycode = default(int?), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), decimal? amountBase = default(decimal?), string _modifiedonbehalfbyValue = default(string), string _pricelevelidValue = default(string), decimal? percentage = default(decimal?), decimal? roundingoptionamount = default(decimal?), decimal? roundingoptionamountBase = default(decimal?), string traversedpath = default(string), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMasyncoperation> productPriceLevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> productPriceLevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> productPriceLevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMdiscounttype discounttypeid = default(MicrosoftDynamicsCRMdiscounttype), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Quantitysellingcode = quantitysellingcode;
            Processid = processid;
            Stageid = stageid;
            Roundingoptioncode = roundingoptioncode;
            Exchangerate = exchangerate;
            this._uomidValue = _uomidValue;
            Productnumber = productnumber;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            Productpricelevelid = productpricelevelid;
            Pricingmethodcode = pricingmethodcode;
            Modifiedon = modifiedon;
            this._discounttypeidValue = _discounttypeidValue;
            this._uomscheduleidValue = _uomscheduleidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Organizationid = organizationid;
            Amount = amount;
            this._createdbyValue = _createdbyValue;
            this._productidValue = _productidValue;
            Roundingpolicycode = roundingpolicycode;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AmountBase = amountBase;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._pricelevelidValue = _pricelevelidValue;
            Percentage = percentage;
            Roundingoptionamount = roundingoptionamount;
            RoundingoptionamountBase = roundingoptionamountBase;
            Traversedpath = traversedpath;
            Uomid = uomid;
            ProductPriceLevelAsyncOperations = productPriceLevelAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            ProductPriceLevelSyncErrors = productPriceLevelSyncErrors;
            StageidProcessstage = stageidProcessstage;
            Pricelevelid = pricelevelid;
            Modifiedonbehalfby = modifiedonbehalfby;
            ProductPriceLevelBulkDeleteFailures = productPriceLevelBulkDeleteFailures;
            Modifiedby = modifiedby;
            Productid = productid;
            Discounttypeid = discounttypeid;
            Uomscheduleid = uomscheduleid;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets quantity of the product that must be sold for a given
        /// price level.
        /// </summary>
        [JsonProperty(PropertyName = "quantitysellingcode")]
        public int? Quantitysellingcode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Process.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the stage.
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// Gets or sets option for rounding the price list.
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptioncode")]
        public int? Roundingoptioncode { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the unit for the price list.
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// Gets or sets user-defined product number.
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets version number of the price list.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the price list.
        /// </summary>
        [JsonProperty(PropertyName = "productpricelevelid")]
        public string Productpricelevelid { get; set; }

        /// <summary>
        /// Gets or sets pricing method applied to the price list.
        /// </summary>
        [JsonProperty(PropertyName = "pricingmethodcode")]
        public int? Pricingmethodcode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the price list was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the discount list associated with
        /// the price list.
        /// </summary>
        [JsonProperty(PropertyName = "_discounttypeid_value")]
        public string _discounttypeidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the unit schedule for the price
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the price list.
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// Gets or sets monetary amount for the price list.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the price
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets product associated with the price list.
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// Gets or sets policy for rounding the price list.
        /// </summary>
        [JsonProperty(PropertyName = "roundingpolicycode")]
        public int? Roundingpolicycode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// price list.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the price list was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the Amount field converted to the system's
        /// default base currency, if specified as a fixed amount. The
        /// calculation uses the exchange rate specified in the Currencies
        /// area.
        /// </summary>
        [JsonProperty(PropertyName = "amount_base")]
        public decimal? AmountBase { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the price level associated with
        /// this price list.
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// Gets or sets percentage for the price list.
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Gets or sets rounding option amount for the price list.
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptionamount")]
        public decimal? Roundingoptionamount { get; set; }

        /// <summary>
        /// Gets or sets shows the Rounding Amount field converted to the
        /// system's default base currency for reporting purposes. The
        /// calculations use the exchange rate specified in the Currencies
        /// area.
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptionamount_base")]
        public decimal? RoundingoptionamountBase { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductPriceLevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductPriceLevelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductPriceLevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttypeid")]
        public MicrosoftDynamicsCRMdiscounttype Discounttypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
