using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class OrderListModel : BaseNopModel
    {
        public OrderListModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableShippingStatuses = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            AvailablePaymentMethods = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Orders.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.OrderStatus")]
        public int[] OrderStatusIds { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.PaymentStatus")]
        public int[] PaymentStatusIds { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.ShippingStatus")]
        public int[] ShippingStatusIds { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.PaymentMethod")]
        public string PaymentMethodSystemName { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.Store")]
        public int StoreId { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.Vendor")]
        public int VendorId { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.Warehouse")]
        public int WarehouseId { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.Product")]
        public int ProductId { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.BillingEmail")]
        public string BillingEmail { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.BillingPhone")]
        public string BillingPhone { get; set; }
        public bool BillingPhoneEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.BillingLastName")]
        public string BillingLastName { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.BillingCountry")]
        public int BillingCountryId { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.OrderNotes")]
        public string OrderNotes { get; set; }

        [NopResourceDisplayName("Merchant.Orders.List.GoDirectlyToNumber")]
        public string GoDirectlyToCustomOrderNumber { get; set; }

        public bool IsLoggedInAsVendor { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableShippingStatuses { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }
        public IList<SelectListItem> AvailablePaymentMethods { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
    }
}