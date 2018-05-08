using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class NeverSoldReportModel : BaseNopModel
    {
        public NeverSoldReportModel()
        {
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.SearchCategory")]
        public int SearchCategoryId { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.SearchManufacturer")]
        public int SearchManufacturerId { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }

        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
        
        [NopResourceDisplayName("Merchant.SalesReport.NeverSold.SearchVendor")]
        public int SearchVendorId { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        public bool IsLoggedInAsVendor { get; set; }
    }
}