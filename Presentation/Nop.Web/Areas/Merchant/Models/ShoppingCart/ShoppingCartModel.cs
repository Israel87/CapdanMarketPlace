using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Orders;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.ShoppingCart
{
    public partial class ShoppingCartModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.CurrentCarts.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.Customer")]
        public string CustomerEmail { get; set; }

        [NopResourceDisplayName("Merchant.CurrentCarts.TotalItems")]
        public int TotalItems { get; set; }
    }

    public partial class ShoppingCartTypeModel : BaseNopModel
    {
        public ShoppingCartTypeModel()
        {
            AvailableShoppingCartTypes = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ShoppingCartType.ShoppingCartType")]
        public ShoppingCartType ShoppingCartType { get; set; }
        public IList<SelectListItem> AvailableShoppingCartTypes { get; set; }
    }
}