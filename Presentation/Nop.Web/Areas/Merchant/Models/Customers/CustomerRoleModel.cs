using System.Collections.Generic;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Validators.Customers;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    [Validator(typeof(CustomerRoleValidator))]
    public partial class CustomerRoleModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.FreeShipping")]
        public bool FreeShipping { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.TaxExempt")]
        public bool TaxExempt { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.Active")]
        public bool Active { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.IsSystemRole")]
        public bool IsSystemRole { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.EnablePasswordLifetime")]
        public bool EnablePasswordLifetime { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.OverrideTaxDisplayType")]
        public bool OverrideTaxDisplayType { get; set; }
        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.DefaultTaxDisplayType")]
        public int DefaultTaxDisplayTypeId { get; set; }
        public SelectList TaxDisplayTypeValues { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.PurchasedWithProduct")]
        public int PurchasedWithProductId { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerRoles.Fields.PurchasedWithProduct")]
        public string PurchasedWithProductName { get; set; }

        #region Nested classes

        public partial class AssociateProductToCustomerRoleModel : BaseNopModel
        {
            public AssociateProductToCustomerRoleModel()
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

            //vendor
            public bool IsLoggedInAsVendor { get; set; }

            public int AssociatedToProductId { get; set; }
        }

        #endregion
    }
}