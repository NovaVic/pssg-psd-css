// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        int? Top40 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        int? Skip40 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        bool? Count40 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        string Filter40 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        string Search40 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the ICsuaddresshistories.
        /// </summary>
        ICsuaddresshistories Csuaddresshistories { get; }

        /// <summary>
        /// Gets the ICsuagencylistings.
        /// </summary>
        ICsuagencylistings Csuagencylistings { get; }

        /// <summary>
        /// Gets the ICsuamporderreminderses.
        /// </summary>
        ICsuamporderreminderses Csuamporderreminderses { get; }

        /// <summary>
        /// Gets the ICsuamporders.
        /// </summary>
        ICsuamporders Csuamporders { get; }

        /// <summary>
        /// Gets the ICsuamps.
        /// </summary>
        ICsuamps Csuamps { get; }

        /// <summary>
        /// Gets the ICsuapplicationforreturnofseizedcannabises.
        /// </summary>
        ICsuapplicationforreturnofseizedcannabises Csuapplicationforreturnofseizedcannabises { get; }

        /// <summary>
        /// Gets the ICsucasebusinessandlocationdetailses.
        /// </summary>
        ICsucasebusinessandlocationdetailses Csucasebusinessandlocationdetailses { get; }

        /// <summary>
        /// Gets the ICsucasepersondetailses.
        /// </summary>
        ICsucasepersondetailses Csucasepersondetailses { get; }

        /// <summary>
        /// Gets the ICsucaseseizedtypesandamountses.
        /// </summary>
        ICsucaseseizedtypesandamountses Csucaseseizedtypesandamountses { get; }

        /// <summary>
        /// Gets the ICsucasetasks.
        /// </summary>
        ICsucasetasks Csucasetasks { get; }

        /// <summary>
        /// Gets the ICsucasevehicledetails.
        /// </summary>
        ICsucasevehicledetails Csucasevehicledetails { get; }

        /// <summary>
        /// Gets the ICsucclasections.
        /// </summary>
        ICsucclasections Csucclasections { get; }

        /// <summary>
        /// Gets the ICsucomplaintseizures.
        /// </summary>
        ICsucomplaintseizures Csucomplaintseizures { get; }

        /// <summary>
        /// Gets the ICsucomplaintses.
        /// </summary>
        ICsucomplaintses Csucomplaintses { get; }

        /// <summary>
        /// Gets the ICsucourtdates.
        /// </summary>
        ICsucourtdates Csucourtdates { get; }

        /// <summary>
        /// Gets the ICsucourtlists.
        /// </summary>
        ICsucourtlists Csucourtlists { get; }

        /// <summary>
        /// Gets the ICsucsaactivities.
        /// </summary>
        ICsucsaactivities Csucsaactivities { get; }

        /// <summary>
        /// Gets the ICsucsaspecifiedactivities.
        /// </summary>
        ICsucsaspecifiedactivities Csucsaspecifiedactivities { get; }

        /// <summary>
        /// Gets the ICsudemandandorders.
        /// </summary>
        ICsudemandandorders Csudemandandorders { get; }

        /// <summary>
        /// Gets the ICsuhasactivechildaction.
        /// </summary>
        ICsuhasactivechildaction Csuhasactivechildaction { get; }

        /// <summary>
        /// Gets the ICsuhearings.
        /// </summary>
        ICsuhearings Csuhearings { get; }

        /// <summary>
        /// Gets the ICsuinjuctiondetails.
        /// </summary>
        ICsuinjuctiondetails Csuinjuctiondetails { get; }

        /// <summary>
        /// Gets the ICsuinspectionsearchs.
        /// </summary>
        ICsuinspectionsearchs Csuinspectionsearchs { get; }

        /// <summary>
        /// Gets the ICsujudicialreviews.
        /// </summary>
        ICsujudicialreviews Csujudicialreviews { get; }

        /// <summary>
        /// Gets the ICsuoffences.
        /// </summary>
        ICsuoffences Csuoffences { get; }

        /// <summary>
        /// Gets the ICsupayments.
        /// </summary>
        ICsupayments Csupayments { get; }

        /// <summary>
        /// Gets the ICsuphonehistories.
        /// </summary>
        ICsuphonehistories Csuphonehistories { get; }

        /// <summary>
        /// Gets the ICsuprovincestatecodes.
        /// </summary>
        ICsuprovincestatecodes Csuprovincestatecodes { get; }

        /// <summary>
        /// Gets the ICsuseizeditemsrequestedforreturns.
        /// </summary>
        ICsuseizeditemsrequestedforreturns Csuseizeditemsrequestedforreturns { get; }

        /// <summary>
        /// Gets the ICsuseizuredetailses.
        /// </summary>
        ICsuseizuredetailses Csuseizuredetailses { get; }

        /// <summary>
        /// Gets the ICsusubjectofcomplaints.
        /// </summary>
        ICsusubjectofcomplaints Csusubjectofcomplaints { get; }

        /// <summary>
        /// Gets the ICsuvehicledetails.
        /// </summary>
        ICsuvehicledetails Csuvehicledetails { get; }

        /// <summary>
        /// Gets the ICsuviolations.
        /// </summary>
        ICsuviolations Csuviolations { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        ISavedqueries Savedqueries { get; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

    }
}
