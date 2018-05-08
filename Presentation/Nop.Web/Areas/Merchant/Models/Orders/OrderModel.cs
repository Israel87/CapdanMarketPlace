﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Tax;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class OrderModel : BaseNopEntityModel
    {
        public OrderModel()
        {
            CustomValues = new Dictionary<string, object>();
            TaxRates = new List<TaxRate>();
            GiftCards = new List<GiftCard>();
            Items = new List<OrderItemModel>();
            UsedDiscounts = new List<UsedDiscountModel>();
        }

        public bool IsLoggedInAsVendor { get; set; }

        //identifiers
        public override int Id { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderGuid")]
        public Guid OrderGuid { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }
        
        //store
        [NopResourceDisplayName("Merchant.Orders.Fields.Store")]
        public string StoreName { get; set; }

        //customer info
        [NopResourceDisplayName("Merchant.Orders.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Customer")]
        public string CustomerInfo { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CustomerEmail")]
        public string CustomerEmail { get; set; }
        public string CustomerFullName { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CustomerIP")]
        public string CustomerIp { get; set; }

        [NopResourceDisplayName("Merchant.Orders.Fields.CustomValues")]
        public Dictionary<string, object> CustomValues { get; set; }

        [NopResourceDisplayName("Merchant.Orders.Fields.Affiliate")]
        public int AffiliateId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Affiliate")]
        public string AffiliateName { get; set; }

        //Used discounts
        [NopResourceDisplayName("Merchant.Orders.Fields.UsedDiscounts")]
        public IList<UsedDiscountModel> UsedDiscounts { get; set; }

        //totals
        public bool AllowCustomersToSelectTaxDisplayType { get; set; }
        public TaxDisplayType TaxDisplayType { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderSubtotalInclTax")]
        public string OrderSubtotalInclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderSubtotalExclTax")]
        public string OrderSubtotalExclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderSubTotalDiscountInclTax")]
        public string OrderSubTotalDiscountInclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderSubTotalDiscountExclTax")]
        public string OrderSubTotalDiscountExclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderShippingInclTax")]
        public string OrderShippingInclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderShippingExclTax")]
        public string OrderShippingExclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.PaymentMethodAdditionalFeeInclTax")]
        public string PaymentMethodAdditionalFeeInclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.PaymentMethodAdditionalFeeExclTax")]
        public string PaymentMethodAdditionalFeeExclTax { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Tax")]
        public string Tax { get; set; }
        public IList<TaxRate> TaxRates { get; set; }
        public bool DisplayTax { get; set; }
        public bool DisplayTaxRates { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderTotalDiscount")]
        public string OrderTotalDiscount { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.RedeemedRewardPoints")]
        public int RedeemedRewardPoints { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.RedeemedRewardPoints")]
        public string RedeemedRewardPointsAmount { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderTotal")]
        public string OrderTotal { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.RefundedAmount")]
        public string RefundedAmount { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Profit")]
        public string Profit { get; set; }

        //edit totals
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderSubtotal")]
        public decimal OrderSubtotalInclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderSubtotal")]
        public decimal OrderSubtotalExclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderSubTotalDiscount")]
        public decimal OrderSubTotalDiscountInclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderSubTotalDiscount")]
        public decimal OrderSubTotalDiscountExclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderShipping")]
        public decimal OrderShippingInclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderShipping")]
        public decimal OrderShippingExclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.PaymentMethodAdditionalFee")]
        public decimal PaymentMethodAdditionalFeeInclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.PaymentMethodAdditionalFee")]
        public decimal PaymentMethodAdditionalFeeExclTaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.Tax")]
        public decimal TaxValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.TaxRates")]
        public string TaxRatesValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderTotalDiscount")]
        public decimal OrderTotalDiscountValue { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.Edit.OrderTotal")]
        public decimal OrderTotalValue { get; set; }

        //associated recurring payment id
        [NopResourceDisplayName("Merchant.Orders.Fields.RecurringPayment")]
        public int RecurringPaymentId { get; set; }

        //order status
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderStatus")]
        public string OrderStatus { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.OrderStatus")]
        public int OrderStatusId { get; set; }

        //payment info
        [NopResourceDisplayName("Merchant.Orders.Fields.PaymentStatus")]
        public string PaymentStatus { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.PaymentMethod")]
        public string PaymentMethod { get; set; }

        //credit card info
        public bool AllowStoringCreditCardNumber { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardType")]
        public string CardType { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardName")]
        public string CardName { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardNumber")]
        public string CardNumber { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardCVV2")]
        public string CardCvv2 { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardExpirationMonth")]
        public string CardExpirationMonth { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CardExpirationYear")]
        public string CardExpirationYear { get; set; }

        //misc payment info
        [NopResourceDisplayName("Merchant.Orders.Fields.AuthorizationTransactionID")]
        public string AuthorizationTransactionId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.CaptureTransactionID")]
        public string CaptureTransactionId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.SubscriptionTransactionID")]
        public string SubscriptionTransactionId { get; set; }

        //shipping info
        public bool IsShippable { get; set; }
        public bool PickUpInStore { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.PickupAddress")]
        public AddressModel PickupAddress { get; set; }
        public string PickupAddressGoogleMapsUrl { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.ShippingStatus")]
        public string ShippingStatus { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.ShippingStatus")]
        public int ShippingStatusId { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.ShippingAddress")]
        public AddressModel ShippingAddress { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.ShippingMethod")]
        public string ShippingMethod { get; set; }
        public string ShippingAddressGoogleMapsUrl { get; set; }
        public bool CanAddNewShipments { get; set; }

        //billing info
        [NopResourceDisplayName("Merchant.Orders.Fields.BillingAddress")]
        public AddressModel BillingAddress { get; set; }
        [NopResourceDisplayName("Merchant.Orders.Fields.VatNumber")]
        public string VatNumber { get; set; }
        
        //gift cards
        public IList<GiftCard> GiftCards { get; set; }

        //items
        public bool HasDownloadableProducts { get; set; }
        public IList<OrderItemModel> Items { get; set; }

        //creation date
        [NopResourceDisplayName("Merchant.Orders.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        //checkout attributes
        public string CheckoutAttributeInfo { get; set; }

        //order notes
        [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.DisplayToCustomer")]
        public bool AddOrderNoteDisplayToCustomer { get; set; }
        [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.Note")]
        public string AddOrderNoteMessage { get; set; }
        public bool AddOrderNoteHasDownload { get; set; }
        [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.Download")]
        [UIHint("Download")]
        public int AddOrderNoteDownloadId { get; set; }

        //refund info
        [NopResourceDisplayName("Merchant.Orders.Fields.PartialRefund.AmountToRefund")]
        public decimal AmountToRefund { get; set; }
        public decimal MaxAmountToRefund { get; set; }
        public string PrimaryStoreCurrencyCode { get; set; }

        //workflow info
        public bool CanCancelOrder { get; set; }
        public bool CanCapture { get; set; }
        public bool CanMarkOrderAsPaid { get; set; }
        public bool CanRefund { get; set; }
        public bool CanRefundOffline { get; set; }
        public bool CanPartiallyRefund { get; set; }
        public bool CanPartiallyRefundOffline { get; set; }
        public bool CanVoid { get; set; }
        public bool CanVoidOffline { get; set; }
        
        #region Nested Classes

        public partial class OrderItemModel : BaseNopEntityModel
        {
            public OrderItemModel()
            {
                PurchasedGiftCardIds = new List<int>();
                ReturnRequests = new List<ReturnRequestBriefModel>();
            }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string VendorName { get; set; }
            public string Sku { get; set; }

            public string PictureThumbnailUrl { get; set; }

            public string UnitPriceInclTax { get; set; }
            public string UnitPriceExclTax { get; set; }
            public decimal UnitPriceInclTaxValue { get; set; }
            public decimal UnitPriceExclTaxValue { get; set; }

            public int Quantity { get; set; }

            public string DiscountInclTax { get; set; }
            public string DiscountExclTax { get; set; }
            public decimal DiscountInclTaxValue { get; set; }
            public decimal DiscountExclTaxValue { get; set; }

            public string SubTotalInclTax { get; set; }
            public string SubTotalExclTax { get; set; }
            public decimal SubTotalInclTaxValue { get; set; }
            public decimal SubTotalExclTaxValue { get; set; }

            public string AttributeInfo { get; set; }
            public string RecurringInfo { get; set; }
            public string RentalInfo { get; set; }
            public IList<ReturnRequestBriefModel> ReturnRequests { get; set; }
            public IList<int> PurchasedGiftCardIds { get; set; }

            public bool IsDownload { get; set; }
            public int DownloadCount { get; set; }
            public DownloadActivationType DownloadActivationType { get; set; }
            public bool IsDownloadActivated { get; set; }
            public Guid LicenseDownloadGuid { get; set; }

            #region Nested Classes

            public partial class ReturnRequestBriefModel : BaseNopEntityModel
            {
                public string CustomNumber { get; set; }
            }

            #endregion
        }

        public partial class TaxRate : BaseNopModel
        {
            public string Rate { get; set; }
            public string Value { get; set; }
        }

        public partial class GiftCard : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.Orders.Fields.GiftCardInfo")]
            public string CouponCode { get; set; }
            public string Amount { get; set; }
        }

        public partial class OrderNote : BaseNopEntityModel
        {
            public int OrderId { get; set; }
            [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.DisplayToCustomer")]
            public bool DisplayToCustomer { get; set; }
            [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.Note")]
            public string Note { get; set; }
            [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.Download")]
            public int DownloadId { get; set; }
            [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.Download")]
            public Guid DownloadGuid { get; set; }
            [NopResourceDisplayName("Merchant.Orders.OrderNotes.Fields.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class UploadLicenseModel : BaseNopModel
        {
            public int OrderId { get; set; }

            public int OrderItemId { get; set; }

            [UIHint("Download")]
            public int LicenseDownloadId { get; set; }

        }

        public partial class AddOrderProductModel : BaseNopModel
        {
            public AddOrderProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchProductName")]
            public string SearchProductName { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [NopResourceDisplayName("Merchant.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int OrderId { get; set; }

            #region Nested classes
            
            public partial class ProductModel : BaseNopEntityModel
            {
                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.Name")]
                public string Name { get; set; }

                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.SKU")]
                public string Sku { get; set; }
            }

            public partial class ProductDetailsModel : BaseNopModel
            {
                public ProductDetailsModel()
                {
                    ProductAttributes = new List<ProductAttributeModel>();
                    GiftCard = new GiftCardModel();
                    Warnings = new List<string>();
                }

                public int ProductId { get; set; }

                public int OrderId { get; set; }

                public ProductType ProductType { get; set; }

                public string Name { get; set; }

                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.UnitPriceInclTax")]
                public decimal UnitPriceInclTax { get; set; }
                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.UnitPriceExclTax")]
                public decimal UnitPriceExclTax { get; set; }

                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.Quantity")]
                public int Quantity { get; set; }

                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.SubTotalInclTax")]
                public decimal SubTotalInclTax { get; set; }
                [NopResourceDisplayName("Merchant.Orders.Products.AddNew.SubTotalExclTax")]
                public decimal SubTotalExclTax { get; set; }

                //product attributes
                public IList<ProductAttributeModel> ProductAttributes { get; set; }
                //gift card info
                public GiftCardModel GiftCard { get; set; }
                //rental
                public bool IsRental { get; set; }

                public List<string> Warnings { get; set; }

                /// <summary>
                /// A value indicating whether this attribute depends on some other attribute
                /// </summary>
                public bool HasCondition { get; set; }

                public bool AutoUpdateOrderTotals { get; set; }
            }

            public partial class ProductAttributeModel : BaseNopEntityModel
            {
                public ProductAttributeModel()
                {
                    Values = new List<ProductAttributeValueModel>();
                }

                public int ProductAttributeId { get; set; }

                public string Name { get; set; }

                public string TextPrompt { get; set; }

                public bool IsRequired { get; set; }

                public bool HasCondition { get; set; }

                /// <summary>
                /// Allowed file extensions for customer uploaded files
                /// </summary>
                public IList<string> AllowedFileExtensions { get; set; }

                public AttributeControlType AttributeControlType { get; set; }

                public IList<ProductAttributeValueModel> Values { get; set; }
            }

            public partial class ProductAttributeValueModel : BaseNopEntityModel
            {
                public string Name { get; set; }

                public bool IsPreSelected { get; set; }

                public string PriceAdjustment { get; set; }

                public decimal PriceAdjustmentValue { get; set; }

                public bool CustomerEntersQty { get; set; }

                public int Quantity { get; set; }
            }

            public partial class GiftCardModel : BaseNopModel
            {
                public bool IsGiftCard { get; set; }

                [NopResourceDisplayName("Merchant.GiftCards.Fields.RecipientName")]
                public string RecipientName { get; set; }
                [DataType(DataType.EmailAddress)]
                [NopResourceDisplayName("Merchant.GiftCards.Fields.RecipientEmail")]
                public string RecipientEmail { get; set; }
                [NopResourceDisplayName("Merchant.GiftCards.Fields.SenderName")]
                public string SenderName { get; set; }
                [DataType(DataType.EmailAddress)]
                [NopResourceDisplayName("Merchant.GiftCards.Fields.SenderEmail")]
                public string SenderEmail { get; set; }
                [NopResourceDisplayName("Merchant.GiftCards.Fields.Message")]
                public string Message { get; set; }

                public GiftCardType GiftCardType { get; set; }
            }

            #endregion
        }

        public partial class UsedDiscountModel:BaseNopModel
        {
            public int DiscountId { get; set; }
            public string DiscountName { get; set; }
        }

        #endregion
    }

    public partial class OrderAggreratorModel : BaseNopModel
    {
        //aggergator properties
        public string aggregatorprofit { get; set; }
        public string aggregatorshipping { get; set; }
        public string aggregatortax { get; set; }
        public string aggregatortotal { get; set; }
    }
}