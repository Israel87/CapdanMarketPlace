using System;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Catalog;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    [Validator(typeof(ProductReviewValidator))]
    public partial class ProductReviewModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Store")]
        public string StoreName { get; set; }
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Product")]
        public int ProductId { get; set; }
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Product")]
        public string ProductName { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Customer")]
        public string CustomerInfo { get; set; }
        
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Title")]
        public string Title { get; set; }
        
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.ReviewText")]
        public string ReviewText { get; set; }
        
        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.ReplyText")]
        public string ReplyText { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.Rating")]
        public int Rating { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductReviews.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        //vendor
        public bool IsLoggedInAsVendor { get; set; }
    }
}