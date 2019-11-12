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
    /// Microsoft.Dynamics.CRM.calendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMcalendar
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendar
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendar
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendar(string name = default(string), string _modifiedonbehalfbyValue = default(string), int? type = default(int?), string primaryuserid = default(string), string _createdonbehalfbyValue = default(string), string _businessunitidValue = default(string), string description = default(string), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _holidayschedulecalendaridValue = default(string), string calendarid = default(string), string _createdbyValue = default(string), bool? isshared = default(bool?), string _organizationidValue = default(string), string _modifiedbyValue = default(string), IList<MicrosoftDynamicsCRMbookableresource> calendarBookableresources = default(IList<MicrosoftDynamicsCRMbookableresource>), IList<MicrosoftDynamicsCRMequipment> calendarEquipment = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMservice> calendarServices = default(IList<MicrosoftDynamicsCRMservice>), IList<MicrosoftDynamicsCRMcalendarrule> calendarCalendarRules = default(IList<MicrosoftDynamicsCRMcalendarrule>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> calendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsla> slabaseBusinesshoursid = default(IList<MicrosoftDynamicsCRMsla>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMorganization> calendarOrganization = default(IList<MicrosoftDynamicsCRMorganization>), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMbusinessunit> businessUnitCalendar = default(IList<MicrosoftDynamicsCRMbusinessunit>), IList<MicrosoftDynamicsCRMannotation> calendarAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMcalendar holidayschedulecalendarid = default(MicrosoftDynamicsCRMcalendar), IList<MicrosoftDynamicsCRMcalendar> calendarCustomercalendarHolidaycalendar = default(IList<MicrosoftDynamicsCRMcalendar>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsystemuser> calendarSystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMasyncoperation> calendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcalendarrule> innerCalendarCalendarRules = default(IList<MicrosoftDynamicsCRMcalendarrule>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Type = type;
            Primaryuserid = primaryuserid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._businessunitidValue = _businessunitidValue;
            Description = description;
            Versionnumber = versionnumber;
            Createdon = createdon;
            Modifiedon = modifiedon;
            this._holidayschedulecalendaridValue = _holidayschedulecalendaridValue;
            Calendarid = calendarid;
            this._createdbyValue = _createdbyValue;
            Isshared = isshared;
            this._organizationidValue = _organizationidValue;
            this._modifiedbyValue = _modifiedbyValue;
            CalendarBookableresources = calendarBookableresources;
            CalendarEquipment = calendarEquipment;
            CalendarServices = calendarServices;
            CalendarCalendarRules = calendarCalendarRules;
            Createdonbehalfby = createdonbehalfby;
            CalendarBulkDeleteFailures = calendarBulkDeleteFailures;
            SlabaseBusinesshoursid = slabaseBusinesshoursid;
            Modifiedby = modifiedby;
            CalendarOrganization = calendarOrganization;
            Businessunitid = businessunitid;
            BusinessUnitCalendar = businessUnitCalendar;
            CalendarAnnotation = calendarAnnotation;
            Holidayschedulecalendarid = holidayschedulecalendarid;
            CalendarCustomercalendarHolidaycalendar = calendarCustomercalendarHolidaycalendar;
            Createdby = createdby;
            CalendarSystemUsers = calendarSystemUsers;
            CalendarAsyncOperations = calendarAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            InnerCalendarCalendarRules = innerCalendarCalendarRules;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "primaryuserid")]
        public string Primaryuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_holidayschedulecalendarid_value")]
        public string _holidayschedulecalendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public string Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isshared")]
        public bool? Isshared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_bookableresources")]
        public IList<MicrosoftDynamicsCRMbookableresource> CalendarBookableresources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_equipment")]
        public IList<MicrosoftDynamicsCRMequipment> CalendarEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_services")]
        public IList<MicrosoftDynamicsCRMservice> CalendarServices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_calendar_rules")]
        public IList<MicrosoftDynamicsCRMcalendarrule> CalendarCalendarRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_businesshoursid")]
        public IList<MicrosoftDynamicsCRMsla> SlabaseBusinesshoursid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_organization")]
        public IList<MicrosoftDynamicsCRMorganization> CalendarOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnit_Calendar")]
        public IList<MicrosoftDynamicsCRMbusinessunit> BusinessUnitCalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> CalendarAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "holidayschedulecalendarid")]
        public MicrosoftDynamicsCRMcalendar Holidayschedulecalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_customercalendar_holidaycalendar")]
        public IList<MicrosoftDynamicsCRMcalendar> CalendarCustomercalendarHolidaycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_system_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> CalendarSystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inner_calendar_calendar_rules")]
        public IList<MicrosoftDynamicsCRMcalendarrule> InnerCalendarCalendarRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}
