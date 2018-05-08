using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Logging
{
    public partial class ActivityLogTypeModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLogType.Fields.Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLogType.Fields.Enabled")]
        public bool Enabled { get; set; }
    }
}