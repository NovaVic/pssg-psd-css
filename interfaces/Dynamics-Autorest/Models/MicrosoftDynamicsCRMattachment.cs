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
    /// Microsoft.Dynamics.CRM.attachment
    /// </summary>
    public partial class MicrosoftDynamicsCRMattachment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMattachment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMattachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMattachment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMattachment(string attachmentid = default(string), string mimetype = default(string), string body = default(string), byte[] bodyBinary = default(byte[]), string subject = default(string), string filename = default(string), int? filesize = default(int?), string versionnumber = default(string), IList<MicrosoftDynamicsCRMsyncerror> attachmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivitymimeattachment> attachmentActivityMimeAttachments = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>))
        {
            Attachmentid = attachmentid;
            Mimetype = mimetype;
            Body = body;
            BodyBinary = bodyBinary;
            Subject = subject;
            Filename = filename;
            Filesize = filesize;
            Versionnumber = versionnumber;
            AttachmentSyncErrors = attachmentSyncErrors;
            AttachmentActivityMimeAttachments = attachmentActivityMimeAttachments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentid")]
        public string Attachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "body_binary")]
        public byte[] BodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attachment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AttachmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachment_activity_mime_attachments")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> AttachmentActivityMimeAttachments { get; set; }

    }
}
