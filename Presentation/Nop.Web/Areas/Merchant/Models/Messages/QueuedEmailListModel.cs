using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    public partial class QueuedEmailListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? SearchStartDate { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? SearchEndDate { get; set; }

        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.FromEmail")]
        public string SearchFromEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.ToEmail")]
        public string SearchToEmail { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.LoadNotSent")]
        public bool SearchLoadNotSent { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.MaxSentTries")]
        public int SearchMaxSentTries { get; set; }

        [NopResourceDisplayName("Merchant.System.QueuedEmails.List.GoDirectlyToNumber")]
        public int GoDirectlyToNumber { get; set; }
    }
}