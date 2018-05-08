using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Settings
{
    public partial class ProductEditorSettingsModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Id")]
        public bool Id { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductType")]
        public bool ProductType { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.VisibleIndividually")]
        public bool VisibleIndividually { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductTemplate")]
        public bool ProductTemplate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MerchantComment")]
        public bool MerchantComment { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Vendor")]
        public bool Vendor { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Stores")]
        public bool Stores { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ACL")]
        public bool ACL { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DisplayOrder")]
        public bool DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AllowCustomerReviews")]
        public bool AllowCustomerReviews { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductTags")]
        public bool ProductTags { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ManufacturerPartNumber")]
        public bool ManufacturerPartNumber { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.GTIN")]
        public bool GTIN { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductCost")]
        public bool ProductCost { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.TierPrices")]
        public bool TierPrices { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Discounts")]
        public bool Discounts { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DisableBuyButton")]
        public bool DisableBuyButton { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DisableWishlistButton")]
        public bool DisableWishlistButton { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AvailableForPreOrder")]
        public bool AvailableForPreOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.CallForPrice")]
        public bool CallForPrice { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.OldPrice")]
        public bool OldPrice { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.CustomerEntersPrice")]
        public bool CustomerEntersPrice { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.PAngV")]
        public bool PAngV { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.RequireOtherProductsAddedToTheCart")]
        public bool RequireOtherProductsAddedToTheCart { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.IsGiftCard")]
        public bool IsGiftCard { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DownloadableProduct")]
        public bool DownloadableProduct { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.RecurringProduct")]
        public bool RecurringProduct { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.IsRental")]
        public bool IsRental { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.FreeShipping")]
        public bool FreeShipping { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ShipSeparately")]
        public bool ShipSeparately { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AdditionalShippingCharge")]
        public bool AdditionalShippingCharge { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DeliveryDate")]
        public bool DeliveryDate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.TelecommunicationsBroadcastingElectronicServices")]
        public bool TelecommunicationsBroadcastingElectronicServices { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductAvailabilityRange")]
        public bool ProductAvailabilityRange { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.UseMultipleWarehouses")]
        public bool UseMultipleWarehouses { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Warehouse")]
        public bool Warehouse { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DisplayStockAvailability")]
        public bool DisplayStockAvailability { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.DisplayStockQuantity")]
        public bool DisplayStockQuantity { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MinimumStockQuantity")]
        public bool MinimumStockQuantity { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.LowStockActivity")]
        public bool LowStockActivity { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.NotifyMerchantForQuantityBelow")]
        public bool NotifyMerchantForQuantityBelow { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Backorders")]
        public bool Backorders { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AllowBackInStockSubscriptions")]
        public bool AllowBackInStockSubscriptions { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MinimumCartQuantity")]
        public bool MinimumCartQuantity { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MaximumCartQuantity")]
        public bool MaximumCartQuantity { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AllowedQuantities")]
        public bool AllowedQuantities { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AllowAddingOnlyExistingAttributeCombinations")]
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.NotReturnable")]
        public bool NotReturnable { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Weight")]
        public bool Weight { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Dimensions")]
        public bool Dimensions { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AvailableStartDate")]
        public bool AvailableStartDate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.AvailableEndDate")]
        public bool AvailableEndDate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MarkAsNew")]
        public bool MarkAsNew { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MarkAsNewStartDate")]
        public bool MarkAsNewStartDate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.MarkAsNewEndDate")]
        public bool MarkAsNewEndDate { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.CreatedOn")]
        public bool CreatedOn { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.UpdatedOn")]
        public bool UpdatedOn { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.RelatedProducts")]
        public bool RelatedProducts { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.CrossSellsProducts")]
        public bool CrossSellsProducts { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Seo")]
        public bool Seo { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.PurchasedWithOrders")]
        public bool PurchasedWithOrders { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.OneColumnProductPage")]
        public bool OneColumnProductPage { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.ProductAttributes")]
        public bool ProductAttributes { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.SpecificationAttributes")]
        public bool SpecificationAttributes { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.Manufacturers")]
        public bool Manufacturers { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.ProductEditor.StockQuantityHistory")]
        public bool StockQuantityHistory { get; set; }
    }
}