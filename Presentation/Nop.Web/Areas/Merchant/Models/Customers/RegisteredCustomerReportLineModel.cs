using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    public partial class RegisteredCustomerReportLineModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Customers.Reports.RegisteredCustomers.Fields.Period")]
        public string Period { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Reports.RegisteredCustomers.Fields.Customers")]
        public int Customers { get; set; }
    }
}