using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class BestsellersReportLineModel : BaseNopModel
    {
        public int ProductId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Fields.Name")]
        public string ProductName { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Fields.TotalAmount")]
        public string TotalAmount { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Fields.TotalQuantity")]
        public decimal TotalQuantity { get; set; }
    }
}