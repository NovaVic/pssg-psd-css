// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial class DynamicsClient : ServiceClient<DynamicsClient>, IDynamicsClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        public int? Top40 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        public int? Skip40 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        public bool? Count40 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        public string Filter40 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        public string Search40 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        public virtual IAccounts Accounts { get; private set; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        public virtual IContacts Contacts { get; private set; }

        /// <summary>
        /// Gets the ICsuaddresshistories.
        /// </summary>
        public virtual ICsuaddresshistories Csuaddresshistories { get; private set; }

        /// <summary>
        /// Gets the ICsuagencylistings.
        /// </summary>
        public virtual ICsuagencylistings Csuagencylistings { get; private set; }

        /// <summary>
        /// Gets the ICsuamporderreminderses.
        /// </summary>
        public virtual ICsuamporderreminderses Csuamporderreminderses { get; private set; }

        /// <summary>
        /// Gets the ICsuamporders.
        /// </summary>
        public virtual ICsuamporders Csuamporders { get; private set; }

        /// <summary>
        /// Gets the ICsuamps.
        /// </summary>
        public virtual ICsuamps Csuamps { get; private set; }

        /// <summary>
        /// Gets the ICsuapplicationforreturnofseizedcannabises.
        /// </summary>
        public virtual ICsuapplicationforreturnofseizedcannabises Csuapplicationforreturnofseizedcannabises { get; private set; }

        /// <summary>
        /// Gets the ICsucasebusinessandlocationdetailses.
        /// </summary>
        public virtual ICsucasebusinessandlocationdetailses Csucasebusinessandlocationdetailses { get; private set; }

        /// <summary>
        /// Gets the ICsucasepersondetailses.
        /// </summary>
        public virtual ICsucasepersondetailses Csucasepersondetailses { get; private set; }

        /// <summary>
        /// Gets the ICsucaseseizedtypesandamountses.
        /// </summary>
        public virtual ICsucaseseizedtypesandamountses Csucaseseizedtypesandamountses { get; private set; }

        /// <summary>
        /// Gets the ICsucasetasks.
        /// </summary>
        public virtual ICsucasetasks Csucasetasks { get; private set; }

        /// <summary>
        /// Gets the ICsucasevehicledetails.
        /// </summary>
        public virtual ICsucasevehicledetails Csucasevehicledetails { get; private set; }

        /// <summary>
        /// Gets the ICsucclasections.
        /// </summary>
        public virtual ICsucclasections Csucclasections { get; private set; }

        /// <summary>
        /// Gets the ICsucomplaintseizures.
        /// </summary>
        public virtual ICsucomplaintseizures Csucomplaintseizures { get; private set; }

        /// <summary>
        /// Gets the ICsucomplaintses.
        /// </summary>
        public virtual ICsucomplaintses Csucomplaintses { get; private set; }

        /// <summary>
        /// Gets the ICsucourtdates.
        /// </summary>
        public virtual ICsucourtdates Csucourtdates { get; private set; }

        /// <summary>
        /// Gets the ICsucourtlists.
        /// </summary>
        public virtual ICsucourtlists Csucourtlists { get; private set; }

        /// <summary>
        /// Gets the ICsucsaactivities.
        /// </summary>
        public virtual ICsucsaactivities Csucsaactivities { get; private set; }

        /// <summary>
        /// Gets the ICsucsaspecifiedactivities.
        /// </summary>
        public virtual ICsucsaspecifiedactivities Csucsaspecifiedactivities { get; private set; }

        /// <summary>
        /// Gets the ICsudemandandorders.
        /// </summary>
        public virtual ICsudemandandorders Csudemandandorders { get; private set; }

        /// <summary>
        /// Gets the ICsuhasactivechildaction.
        /// </summary>
        public virtual ICsuhasactivechildaction Csuhasactivechildaction { get; private set; }

        /// <summary>
        /// Gets the ICsuhearings.
        /// </summary>
        public virtual ICsuhearings Csuhearings { get; private set; }

        /// <summary>
        /// Gets the ICsuinjuctiondetails.
        /// </summary>
        public virtual ICsuinjuctiondetails Csuinjuctiondetails { get; private set; }

        /// <summary>
        /// Gets the ICsuinspectionsearchs.
        /// </summary>
        public virtual ICsuinspectionsearchs Csuinspectionsearchs { get; private set; }

        /// <summary>
        /// Gets the ICsujudicialreviews.
        /// </summary>
        public virtual ICsujudicialreviews Csujudicialreviews { get; private set; }

        /// <summary>
        /// Gets the ICsuoffences.
        /// </summary>
        public virtual ICsuoffences Csuoffences { get; private set; }

        /// <summary>
        /// Gets the ICsupayments.
        /// </summary>
        public virtual ICsupayments Csupayments { get; private set; }

        /// <summary>
        /// Gets the ICsuphonehistories.
        /// </summary>
        public virtual ICsuphonehistories Csuphonehistories { get; private set; }

        /// <summary>
        /// Gets the ICsuprovincestatecodes.
        /// </summary>
        public virtual ICsuprovincestatecodes Csuprovincestatecodes { get; private set; }

        /// <summary>
        /// Gets the ICsuseizeditemsrequestedforreturns.
        /// </summary>
        public virtual ICsuseizeditemsrequestedforreturns Csuseizeditemsrequestedforreturns { get; private set; }

        /// <summary>
        /// Gets the ICsuseizuredetailses.
        /// </summary>
        public virtual ICsuseizuredetailses Csuseizuredetailses { get; private set; }

        /// <summary>
        /// Gets the ICsusubjectofcomplaints.
        /// </summary>
        public virtual ICsusubjectofcomplaints Csusubjectofcomplaints { get; private set; }

        /// <summary>
        /// Gets the ICsuvehicledetails.
        /// </summary>
        public virtual ICsuvehicledetails Csuvehicledetails { get; private set; }

        /// <summary>
        /// Gets the ICsuviolations.
        /// </summary>
        public virtual ICsuviolations Csuviolations { get; private set; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        public virtual IEntitydefinitions Entitydefinitions { get; private set; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        public virtual IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; private set; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        public virtual IInvoices Invoices { get; private set; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        public virtual ISavedqueries Savedqueries { get; private set; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        public virtual ISharepointdocumentlocations Sharepointdocumentlocations { get; private set; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        public virtual ISharepointsites Sharepointsites { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DynamicsClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Accounts = new Accounts(this);
            Contacts = new Contacts(this);
            Csuaddresshistories = new Csuaddresshistories(this);
            Csuagencylistings = new Csuagencylistings(this);
            Csuamporderreminderses = new Csuamporderreminderses(this);
            Csuamporders = new Csuamporders(this);
            Csuamps = new Csuamps(this);
            Csuapplicationforreturnofseizedcannabises = new Csuapplicationforreturnofseizedcannabises(this);
            Csucasebusinessandlocationdetailses = new Csucasebusinessandlocationdetailses(this);
            Csucasepersondetailses = new Csucasepersondetailses(this);
            Csucaseseizedtypesandamountses = new Csucaseseizedtypesandamountses(this);
            Csucasetasks = new Csucasetasks(this);
            Csucasevehicledetails = new Csucasevehicledetails(this);
            Csucclasections = new Csucclasections(this);
            Csucomplaintseizures = new Csucomplaintseizures(this);
            Csucomplaintses = new Csucomplaintses(this);
            Csucourtdates = new Csucourtdates(this);
            Csucourtlists = new Csucourtlists(this);
            Csucsaactivities = new Csucsaactivities(this);
            Csucsaspecifiedactivities = new Csucsaspecifiedactivities(this);
            Csudemandandorders = new Csudemandandorders(this);
            Csuhasactivechildaction = new Csuhasactivechildaction(this);
            Csuhearings = new Csuhearings(this);
            Csuinjuctiondetails = new Csuinjuctiondetails(this);
            Csuinspectionsearchs = new Csuinspectionsearchs(this);
            Csujudicialreviews = new Csujudicialreviews(this);
            Csuoffences = new Csuoffences(this);
            Csupayments = new Csupayments(this);
            Csuphonehistories = new Csuphonehistories(this);
            Csuprovincestatecodes = new Csuprovincestatecodes(this);
            Csuseizeditemsrequestedforreturns = new Csuseizeditemsrequestedforreturns(this);
            Csuseizuredetailses = new Csuseizuredetailses(this);
            Csusubjectofcomplaints = new Csusubjectofcomplaints(this);
            Csuvehicledetails = new Csuvehicledetails(this);
            Csuviolations = new Csuviolations(this);
            Entitydefinitions = new Entitydefinitions(this);
            Globaloptionsetdefinitions = new Globaloptionsetdefinitions(this);
            Invoices = new Invoices(this);
            Savedqueries = new Savedqueries(this);
            Sharepointdocumentlocations = new Sharepointdocumentlocations(this);
            Sharepointsites = new Sharepointsites(this);
            BaseUri = new System.Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
