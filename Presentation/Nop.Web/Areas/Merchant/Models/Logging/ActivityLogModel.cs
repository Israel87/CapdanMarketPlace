using System;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Logging
{
    public partial class ActivityLogModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.Customer")]
        public string CustomerEmail { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.Comment")]
        public string Comment { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Customers.ActivityLog.IpAddress")]
        public string IpAddress { get; set; }
    }
}
