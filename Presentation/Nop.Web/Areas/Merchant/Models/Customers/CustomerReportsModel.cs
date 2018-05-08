using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    public partial class CustomerReportsModel : BaseNopModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}