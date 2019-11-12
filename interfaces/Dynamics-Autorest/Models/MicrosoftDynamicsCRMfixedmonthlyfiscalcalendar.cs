// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.fixedmonthlyfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar(string _transactioncurrencyidValue = default(string), string _modifiedonbehalfbyValue = default(string), decimal? period5 = default(decimal?), decimal? period6Base = default(decimal?), decimal? period5Base = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string userfiscalcalendarid = default(string), string _businessunitidValue = default(string), decimal? period4Base = default(decimal?), string _salespersonidValue = default(string), decimal? period11 = default(decimal?), decimal? period12Base = default(decimal?), decimal? period9Base = default(decimal?), decimal? period12 = default(decimal?), decimal? period13 = default(decimal?), decimal? period10 = default(decimal?), decimal? period2Base = default(decimal?), int? utcconversiontimezonecode = default(int?), decimal? period6 = default(decimal?), decimal? period8Base = default(decimal?), decimal? period3 = default(decimal?), decimal? period2 = default(decimal?), decimal? exchangerate = default(decimal?), decimal? period11Base = default(decimal?), decimal? period1Base = default(decimal?), decimal? period8 = default(decimal?), decimal? period13Base = default(decimal?), int? fiscalperiodtype = default(int?), string _createdbyValue = default(string), decimal? period9 = default(decimal?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), decimal? period10Base = default(decimal?), decimal? period7 = default(decimal?), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), decimal? period3Base = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? period4 = default(decimal?), decimal? period7Base = default(decimal?), decimal? period1 = default(decimal?), IList<MicrosoftDynamicsCRMbulkdeletefailure> fixedMonthlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> fixedMonthlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Period5 = period5;
            Period6Base = period6Base;
            Period5Base = period5Base;
            Createdon = createdon;
            Userfiscalcalendarid = userfiscalcalendarid;
            this._businessunitidValue = _businessunitidValue;
            Period4Base = period4Base;
            this._salespersonidValue = _salespersonidValue;
            Period11 = period11;
            Period12Base = period12Base;
            Period9Base = period9Base;
            Period12 = period12;
            Period13 = period13;
            Period10 = period10;
            Period2Base = period2Base;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Period6 = period6;
            Period8Base = period8Base;
            Period3 = period3;
            Period2 = period2;
            Exchangerate = exchangerate;
            Period11Base = period11Base;
            Period1Base = period1Base;
            Period8 = period8;
            Period13Base = period13Base;
            Fiscalperiodtype = fiscalperiodtype;
            this._createdbyValue = _createdbyValue;
            Period9 = period9;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Effectiveon = effectiveon;
            Period10Base = period10Base;
            Period7 = period7;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Period3Base = period3Base;
            Modifiedon = modifiedon;
            Period4 = period4;
            Period7Base = period7Base;
            Period1 = period1;
            FixedMonthlyFiscalCalendarBulkDeleteFailures = fixedMonthlyFiscalCalendarBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            FixedMonthlyFiscalCalendarAsyncOperations = fixedMonthlyFiscalCalendarAsyncOperations;
            Salespersonid = salespersonid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5")]
        public decimal? Period5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6_base")]
        public decimal? Period6Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5_base")]
        public decimal? Period5Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4_base")]
        public decimal? Period4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11")]
        public decimal? Period11 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12_base")]
        public decimal? Period12Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9_base")]
        public decimal? Period9Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12")]
        public decimal? Period12 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13")]
        public decimal? Period13 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10")]
        public decimal? Period10 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2_base")]
        public decimal? Period2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6")]
        public decimal? Period6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8_base")]
        public decimal? Period8Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3")]
        public decimal? Period3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2")]
        public decimal? Period2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11_base")]
        public decimal? Period11Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1_base")]
        public decimal? Period1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8")]
        public decimal? Period8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13_base")]
        public decimal? Period13Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9")]
        public decimal? Period9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10_base")]
        public decimal? Period10Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7")]
        public decimal? Period7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3_base")]
        public decimal? Period3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4")]
        public decimal? Period4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7_base")]
        public decimal? Period7Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1")]
        public decimal? Period1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FixedMonthlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FixedMonthlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
