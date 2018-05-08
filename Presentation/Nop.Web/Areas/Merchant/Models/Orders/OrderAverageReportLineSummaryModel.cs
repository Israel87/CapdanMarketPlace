using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class OrderAverageReportLineSummaryModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.SalesReport.Average.OrderStatus")]
        public string OrderStatus { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Average.SumTodayOrders")]
        public string SumTodayOrders { get; set; }
        
        [NopResourceDisplayName("Merchant.SalesReport.Average.SumThisWeekOrders")]
        public string SumThisWeekOrders { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Average.SumThisMonthOrders")]
        public string SumThisMonthOrders { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Average.SumThisYearOrders")]
        public string SumThisYearOrders { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Average.SumAllTimeOrders")]
        public string SumAllTimeOrders { get; set; }
    }
}
