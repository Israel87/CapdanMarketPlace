using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class BestsellersReportModel : BaseNopModel
    {
        public BestsellersReportModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Store")]
        public int StoreId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.OrderStatus")]
        public int OrderStatusId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Category")]
        public int CategoryId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Manufacturer")]
        public int ManufacturerId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.BillingCountry")]
        public int BillingCountryId { get; set; }
        [NopResourceDisplayName("Merchant.SalesReport.Bestsellers.Vendor")]
        public int VendorId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        public bool IsLoggedInAsVendor { get; set; }
    }
}