using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Affiliates
{
    public partial class AffiliateListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Affiliates.List.SearchFirstName")]
        public string SearchFirstName { get; set; }

        [NopResourceDisplayName("Merchant.Affiliates.List.SearchLastName")]
        public string SearchLastName { get; set; }

        [NopResourceDisplayName("Merchant.Affiliates.List.SearchFriendlyUrlName")]
        public string SearchFriendlyUrlName { get; set; }

        [NopResourceDisplayName("Merchant.Affiliates.List.LoadOnlyWithOrders")]
        public bool LoadOnlyWithOrders { get; set; }
        [NopResourceDisplayName("Merchant.Affiliates.List.OrdersCreatedFromUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedFromUtc { get; set; }
        [NopResourceDisplayName("Merchant.Affiliates.List.OrdersCreatedToUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedToUtc { get; set; }
    }
}