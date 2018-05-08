using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    public partial class NewsLetterSubscriptionListModel : BaseNopModel
    {
        public NewsLetterSubscriptionListModel()
        {
            AvailableStores = new List<SelectListItem>();
            ActiveList = new List<SelectListItem>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.SearchEmail")]
        public string SearchEmail { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.SearchStore")]
        public int StoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.SearchActive")]
        public int ActiveId { get; set; }
        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.SearchActive")]
        public IList<SelectListItem> ActiveList { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.CustomerRoles")]
        public int CustomerRoleId { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }
    }
}