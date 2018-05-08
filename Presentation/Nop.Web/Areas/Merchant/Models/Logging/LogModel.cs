using System;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Logging
{
    public partial class LogModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.Log.Fields.LogLevel")]
        public string LogLevel { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.ShortMessage")]
        public string ShortMessage { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.FullMessage")]
        public string FullMessage { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.IPAddress")]
        public string IpAddress { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.Customer")]
        public int? CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.System.Log.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.PageURL")]
        public string PageUrl { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.ReferrerURL")]
        public string ReferrerUrl { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}