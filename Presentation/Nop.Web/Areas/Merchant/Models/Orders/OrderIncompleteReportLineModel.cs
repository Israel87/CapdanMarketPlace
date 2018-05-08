using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class OrderIncompleteReportLineModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Incomplete.Count")]
        public int Count { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Incomplete.View")]
        public string ViewLink { get; set; }
    }
}
