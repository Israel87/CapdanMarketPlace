using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class OrderAddressModel : BaseNopModel
    {
        public int OrderId { get; set; }

        public AddressModel Address { get; set; }
    }
}