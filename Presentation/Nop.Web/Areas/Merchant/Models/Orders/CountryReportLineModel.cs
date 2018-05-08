using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class CountryReportLineModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.SalesReport.Country.Fields.CountryName")]
        public string CountryName { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Country.Fields.TotalOrders")]
        public int TotalOrders { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Country.Fields.SumOrders")]
        public string SumOrders { get; set; }
    }
}