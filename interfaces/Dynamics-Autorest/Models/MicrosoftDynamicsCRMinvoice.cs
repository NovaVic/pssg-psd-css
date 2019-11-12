// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.invoice
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvoice
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice(string shiptoName = default(string), string _contactidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statuscode = default(int?), decimal? exchangerate = default(decimal?), string _modifiedbyValue = default(string), int? onholdtime = default(int?), bool? ispricelocked = default(bool?), decimal? discountamountBase = default(decimal?), string stageid = default(string), decimal? totalamountlessfreightBase = default(decimal?), decimal? totalamountBase = default(decimal?), string versionnumber = default(string), int? pricingerrorcode = default(int?), decimal? discountpercentage = default(decimal?), decimal? totallineitemdiscountamountBase = default(decimal?), string _accountidValue = default(string), decimal? freightamount = default(decimal?), string billtoLine2 = default(string), string shiptoPostalcode = default(string), string shiptoLine2 = default(string), string _modifiedonbehalfbyValue = default(string), string description = default(string), int? statecode = default(int?), string _opportunityidValue = default(string), string billtoPostalcode = default(string), decimal? totalamount = default(decimal?), string _transactioncurrencyidValue = default(string), string shiptoStateorprovince = default(string), decimal? totallineitemdiscountamount = default(decimal?), string entityimageid = default(string), int? utcconversiontimezonecode = default(int?), string shiptoComposite = default(string), decimal? totaltaxBase = default(decimal?), int? paymenttermscode = default(int?), string name = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string shiptoTelephone = default(string), string billtoLine3 = default(string), string processid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string billtoTelephone = default(string), string shiptoCountry = default(string), int? prioritycode = default(int?), string billtoComposite = default(string), string _salesorderidValue = default(string), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string emailaddress = default(string), string shiptoLine1 = default(string), string _slaidValue = default(string), int? timezoneruleversionnumber = default(int?), bool? willcall = default(bool?), string shiptoCity = default(string), string _pricelevelidValue = default(string), string shiptoLine3 = default(string), decimal? totaldiscountamount = default(decimal?), string _owningteamValue = default(string), System.DateTimeOffset? lastbackofficesubmit = default(System.DateTimeOffset?), long? entityimageTimestamp = default(long?), string billtoLine1 = default(string), string entityimageUrl = default(string), string _owninguserValue = default(string), decimal? totalamountlessfreight = default(decimal?), string _slainvokedidValue = default(string), decimal? freightamountBase = default(decimal?), string invoicenumber = default(string), string billtoFax = default(string), string billtoCity = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), string invoiceid = default(string), decimal? totallineitemamount = default(decimal?), string billtoCountry = default(string), string shiptoFax = default(string), string _owneridValue = default(string), System.DateTimeOffset? datedelivered = default(System.DateTimeOffset?), decimal? discountamount = default(decimal?), string billtoName = default(string), string billtoStateorprovince = default(string), decimal? totallineitemamountBase = default(decimal?), decimal? totaldiscountamountBase = default(decimal?), byte[] entityimage = default(byte[]), int? shiptoFreighttermscode = default(int?), string traversedpath = default(string), string _createdbyValue = default(string), int? shippingmethodcode = default(int?), string _customeridValue = default(string), decimal? totaltax = default(decimal?), System.DateTime? duedate = default(System.DateTime?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> invoiceActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> invoiceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> invoiceActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> invoiceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> invoiceMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> invoiceProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> invoiceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> invoicePrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMappointment> invoiceAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> invoiceEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> invoiceFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> invoiceLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> invoicePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> invoiceTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> invoiceRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> invoiceSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> invoiceConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> invoiceConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> invoiceAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> invoiceServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMcontact> contactinvoicesAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMinvoicedetail> invoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceInvoice = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMsla slainvokedidInvoiceSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slaInvoiceSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMcsuCasetask> invoiceCsuCasetasks = default(IList<MicrosoftDynamicsCRMcsuCasetask>))
        {
            ShiptoName = shiptoName;
            this._contactidValue = _contactidValue;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            Exchangerate = exchangerate;
            this._modifiedbyValue = _modifiedbyValue;
            Onholdtime = onholdtime;
            Ispricelocked = ispricelocked;
            DiscountamountBase = discountamountBase;
            Stageid = stageid;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            TotalamountBase = totalamountBase;
            Versionnumber = versionnumber;
            Pricingerrorcode = pricingerrorcode;
            Discountpercentage = discountpercentage;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            this._accountidValue = _accountidValue;
            Freightamount = freightamount;
            BilltoLine2 = billtoLine2;
            ShiptoPostalcode = shiptoPostalcode;
            ShiptoLine2 = shiptoLine2;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Description = description;
            Statecode = statecode;
            this._opportunityidValue = _opportunityidValue;
            BilltoPostalcode = billtoPostalcode;
            Totalamount = totalamount;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            ShiptoStateorprovince = shiptoStateorprovince;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            Entityimageid = entityimageid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            ShiptoComposite = shiptoComposite;
            TotaltaxBase = totaltaxBase;
            Paymenttermscode = paymenttermscode;
            Name = name;
            Overriddencreatedon = overriddencreatedon;
            ShiptoTelephone = shiptoTelephone;
            BilltoLine3 = billtoLine3;
            Processid = processid;
            Createdon = createdon;
            BilltoTelephone = billtoTelephone;
            ShiptoCountry = shiptoCountry;
            Prioritycode = prioritycode;
            BilltoComposite = billtoComposite;
            this._salesorderidValue = _salesorderidValue;
            Lastonholdtime = lastonholdtime;
            Emailaddress = emailaddress;
            ShiptoLine1 = shiptoLine1;
            this._slaidValue = _slaidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Willcall = willcall;
            ShiptoCity = shiptoCity;
            this._pricelevelidValue = _pricelevelidValue;
            ShiptoLine3 = shiptoLine3;
            Totaldiscountamount = totaldiscountamount;
            this._owningteamValue = _owningteamValue;
            Lastbackofficesubmit = lastbackofficesubmit;
            EntityimageTimestamp = entityimageTimestamp;
            BilltoLine1 = billtoLine1;
            EntityimageUrl = entityimageUrl;
            this._owninguserValue = _owninguserValue;
            Totalamountlessfreight = totalamountlessfreight;
            this._slainvokedidValue = _slainvokedidValue;
            FreightamountBase = freightamountBase;
            Invoicenumber = invoicenumber;
            BilltoFax = billtoFax;
            BilltoCity = billtoCity;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Invoiceid = invoiceid;
            Totallineitemamount = totallineitemamount;
            BilltoCountry = billtoCountry;
            ShiptoFax = shiptoFax;
            this._owneridValue = _owneridValue;
            Datedelivered = datedelivered;
            Discountamount = discountamount;
            BilltoName = billtoName;
            BilltoStateorprovince = billtoStateorprovince;
            TotallineitemamountBase = totallineitemamountBase;
            TotaldiscountamountBase = totaldiscountamountBase;
            Entityimage = entityimage;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Traversedpath = traversedpath;
            this._createdbyValue = _createdbyValue;
            Shippingmethodcode = shippingmethodcode;
            this._customeridValue = _customeridValue;
            Totaltax = totaltax;
            Duedate = duedate;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            InvoiceActivityPointers = invoiceActivityPointers;
            InvoiceSyncErrors = invoiceSyncErrors;
            InvoiceActivityParties = invoiceActivityParties;
            InvoiceAsyncOperations = invoiceAsyncOperations;
            InvoiceMailboxTrackingFolder = invoiceMailboxTrackingFolder;
            InvoiceProcessSessions = invoiceProcessSessions;
            InvoiceBulkDeleteFailures = invoiceBulkDeleteFailures;
            InvoicePrincipalobjectattributeaccess = invoicePrincipalobjectattributeaccess;
            StageidProcessstage = stageidProcessstage;
            Transactioncurrencyid = transactioncurrencyid;
            InvoiceAppointments = invoiceAppointments;
            InvoiceEmails = invoiceEmails;
            InvoiceFaxes = invoiceFaxes;
            InvoiceLetters = invoiceLetters;
            InvoicePhonecalls = invoicePhonecalls;
            InvoiceTasks = invoiceTasks;
            InvoiceRecurringAppointmentMasters = invoiceRecurringAppointmentMasters;
            InvoiceSocialActivities = invoiceSocialActivities;
            InvoiceConnections1 = invoiceConnections1;
            InvoiceConnections2 = invoiceConnections2;
            InvoiceAnnotation = invoiceAnnotation;
            InvoiceServiceAppointments = invoiceServiceAppointments;
            CustomeridAccount = customeridAccount;
            ContactinvoicesAssociation = contactinvoicesAssociation;
            CustomeridContact = customeridContact;
            InvoiceDetails = invoiceDetails;
            SlakpiinstanceInvoice = slakpiinstanceInvoice;
            Opportunityid = opportunityid;
            Pricelevelid = pricelevelid;
            Salesorderid = salesorderid;
            SlainvokedidInvoiceSla = slainvokedidInvoiceSla;
            SlaInvoiceSla = slaInvoiceSla;
            InvoiceCsuCasetasks = invoiceCsuCasetasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispricelocked")]
        public bool? Ispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        public decimal? DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        public decimal? TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        public decimal? TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public decimal? Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        public decimal? TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        public decimal? Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        public decimal? Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        public decimal? Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        public decimal? TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        public decimal? Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastbackofficesubmit")]
        public System.DateTimeOffset? Lastbackofficesubmit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        public decimal? Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        public decimal? FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicenumber")]
        public string Invoicenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public string Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        public decimal? Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datedelivered")]
        public System.DateTimeOffset? Datedelivered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        public decimal? Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        public decimal? TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        public decimal? TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        public decimal? Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "duedate")]
        public System.DateTime? Duedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "Invoice_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> InvoiceActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> InvoiceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> InvoiceActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> InvoiceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_MailboxTrackingFolder")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> InvoiceMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> InvoiceProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> InvoiceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> InvoicePrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> InvoiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Emails")]
        public IList<MicrosoftDynamicsCRMemail> InvoiceEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> InvoiceFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Letters")]
        public IList<MicrosoftDynamicsCRMletter> InvoiceLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> InvoicePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> InvoiceTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> InvoiceRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> InvoiceSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> InvoiceAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> InvoiceServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_association")]
        public IList<MicrosoftDynamicsCRMcontact> ContactinvoicesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> InvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_invoice")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlaInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_csu_casetasks")]
        public IList<MicrosoftDynamicsCRMcsuCasetask> InvoiceCsuCasetasks { get; set; }

    }
}
