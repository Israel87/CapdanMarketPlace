using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class GiftCardListModel : BaseNopModel
    {
        public GiftCardListModel()
        {
            ActivatedList = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.GiftCards.List.CouponCode")]
        public string CouponCode { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.List.RecipientName")]
        public string RecipientName { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.List.Activated")]
        public int ActivatedId { get; set; }
        [NopResourceDisplayName("Merchant.GiftCards.List.Activated")]
        public IList<SelectListItem> ActivatedList { get; set; }
    }
}