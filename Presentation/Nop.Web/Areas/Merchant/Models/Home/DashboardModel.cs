using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Home
{
    public partial class DashboardModel : BaseNopModel
    {
        public bool IsLoggedInAsVendor { get; set; }
    }
}