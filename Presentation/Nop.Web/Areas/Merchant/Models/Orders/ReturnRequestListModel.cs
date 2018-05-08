using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public class ReturnRequestListModel: BaseNopModel
    {
        public ReturnRequestListModel()
        {
            ReturnRequestStatusList = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ReturnRequests.SearchStartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.SearchEndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.SearchCustomNumber")]
        public string CustomNumber { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.SearchReturnRequestStatus")]
        public int ReturnRequestStatusId { get; set; }
        public IList<SelectListItem> ReturnRequestStatusList { get; set; }
    }
}