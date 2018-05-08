using System;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.CurrentCarts.Store")]
        public string Store { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.Product")]
        public int ProductId { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.Product")]
        public string ProductName { get; set; }
        public string AttributeInfo { get; set; }

        [NopResourceDisplayName("Merchant.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.Total")]
        public string Total { get; set; }
        [NopResourceDisplayName("Merchant.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}