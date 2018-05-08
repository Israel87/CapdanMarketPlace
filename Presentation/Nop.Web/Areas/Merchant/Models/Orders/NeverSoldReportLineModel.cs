using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class NeverSoldReportLineModel : BaseNopModel
    {
        public int ProductId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.Fields.Name")]
        public string ProductName { get; set; }
    }
}