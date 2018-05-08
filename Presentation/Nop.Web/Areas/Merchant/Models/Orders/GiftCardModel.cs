using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class GiftCardModel: BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.GiftCards.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.OrderId")]
        public int? PurchasedWithOrderId { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.CustomOrderNumber")]
        public string PurchasedWithOrderNumber { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.Amount")]
        public decimal Amount { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.Amount")]
        public string AmountStr { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.RemainingAmount")]
        public string RemainingAmountStr { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.IsGiftCardActivated")]
        public bool IsGiftCardActivated { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.GiftCardCouponCode")]
        public string GiftCardCouponCode { get; set; }

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

        [NopResourceDisplayName("Merchant.GiftCards.Fields.IsRecipientNotified")]
        public bool IsRecipientNotified { get; set; }

        [NopResourceDisplayName("Merchant.GiftCards.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }

        #region Nested classes

        public partial class GiftCardUsageHistoryModel : BaseNopEntityModel
        {
            [NopResourceDisplayName("Merchant.GiftCards.History.UsedValue")]
            public string UsedValue { get; set; }
            
            public int OrderId { get; set; }

            [NopResourceDisplayName("Merchant.GiftCards.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }

            [NopResourceDisplayName("Merchant.GiftCards.History.CustomOrderNumber")]
            public string CustomOrderNumber { get; set; }
        }

        #endregion
    }
}