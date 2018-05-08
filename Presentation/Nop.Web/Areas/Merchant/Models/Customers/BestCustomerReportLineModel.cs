using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    public partial class BestCustomerReportLineModel : BaseNopModel
    {
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.Fields.Customer")]
        public string CustomerName { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.Fields.OrderTotal")]
        public string OrderTotal { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.Fields.OrderCount")]
        public decimal OrderCount { get; set; }
    }
}