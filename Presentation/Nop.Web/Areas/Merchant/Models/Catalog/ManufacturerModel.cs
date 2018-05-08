using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Validators.Catalog;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    [Validator(typeof(ManufacturerValidator))]
    public partial class ManufacturerModel : BaseNopEntityModel, ILocalizedModel<ManufacturerLocalizedModel>
    {
        public ManufacturerModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<ManufacturerLocalizedModel>();
            AvailableManufacturerTemplates = new List<SelectListItem>();

            AvailableDiscounts = new List<SelectListItem>();
            SelectedDiscountIds = new List<int>();

            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.ManufacturerTemplate")]
        public int ManufacturerTemplateId { get; set; }
        public IList<SelectListItem> AvailableManufacturerTemplates { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.SeName")]
        public string SeName { get; set; }

        [UIHint("Picture")]
        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Picture")]
        public int PictureId { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.PageSize")]
        public int PageSize { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.PriceRanges")]
        public string PriceRanges { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Deleted")]
        public bool Deleted { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
        
        public IList<ManufacturerLocalizedModel> Locales { get; set; }

        //ACL (customer roles)
        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.AclCustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }
        
        //store mapping
        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        //discounts
        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Discounts")]
        public IList<int> SelectedDiscountIds { get; set; }
        public IList<SelectListItem> AvailableDiscounts { get; set; }

        #region Nested classes

        public partial class ManufacturerProductModel : BaseNopEntityModel
        {
            public int ManufacturerId { get; set; }

            public int ProductId { get; set; }

            [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Products.Fields.Product")]
            public string ProductName { get; set; }

            [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Products.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Products.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddManufacturerProductModel : BaseNopModel
        {
            public AddManufacturerProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchProductName")]
            public string SearchProductName { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchStore")]
            public int SearchStoreId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchVendor")]
            public int SearchVendorId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ManufacturerId { get; set; }

            public int[] SelectedProductIds { get; set; }
        }

        #endregion
    }

    public partial class ManufacturerLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.Description")]
        public string Description {get;set;}

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.Fields.SeName")]
        public string SeName { get; set; }
    }
}