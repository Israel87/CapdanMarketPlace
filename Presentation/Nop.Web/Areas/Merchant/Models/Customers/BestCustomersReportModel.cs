using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    public partial class BestCustomersReportModel : BaseNopModel
    {
        public BestCustomersReportModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableShippingStatuses = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.OrderStatus")]
        public int OrderStatusId { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Reports.BestBy.ShippingStatus")]
        public int ShippingStatusId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableShippingStatuses { get; set; }
    }
}