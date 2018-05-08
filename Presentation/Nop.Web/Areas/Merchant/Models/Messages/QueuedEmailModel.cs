using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Messages;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    [Validator(typeof(QueuedEmailValidator))]
    public partial class QueuedEmailModel: BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.Id")]
        public override int Id { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.Priority")]
        public string PriorityName { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.From")]
        public string From { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.FromName")]
        public string FromName { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.To")]
        public string To { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.ToName")]
        public string ToName { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.ReplyTo")]
        public string ReplyTo { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.ReplyToName")]
        public string ReplyToName { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.CC")]
        public string CC { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.Bcc")]
        public string Bcc { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.Subject")]
        public string Subject { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.Body")]
        public string Body { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.AttachmentFilePath")]
        public string AttachmentFilePath { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.AttachedDownload")]
        [UIHint("Download")]
        public int AttachedDownloadId { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.SendImmediately")]
        public bool SendImmediately { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.DontSendBeforeDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DontSendBeforeDate { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.SentTries")]
        public int SentTries { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.SentOn")]
        public DateTime? SentOn { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.Fields.EmailAccountName")]
        public string EmailAccountName { get; set; }
    }
}