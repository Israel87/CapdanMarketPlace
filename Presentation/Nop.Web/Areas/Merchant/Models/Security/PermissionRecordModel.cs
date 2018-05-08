using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Security
{
    public partial class PermissionRecordModel : BaseNopModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
    }
}