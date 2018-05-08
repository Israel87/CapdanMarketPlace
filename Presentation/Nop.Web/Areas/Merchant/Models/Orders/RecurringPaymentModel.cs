using System;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    public partial class RecurringPaymentModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.ID")]
        public override int Id { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.CycleLength")]
        public int CycleLength { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.CyclePeriod")]
        public int CyclePeriodId { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.CyclePeriod")]
        public string CyclePeriodStr { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.TotalCycles")]
        public int TotalCycles { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.StartDate")]
        public string StartDate { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.NextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.CyclesRemaining")]
        public int CyclesRemaining { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.InitialOrder")]
        public int InitialOrderId { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [NopResourceDisplayName("Merchant.RecurringPayments.Fields.PaymentType")]
        public string PaymentType { get; set; }
        
        public bool CanCancelRecurringPayment { get; set; }

        public bool LastPaymentFailed { get; set; }

        #region Nested classes

        public partial class RecurringPaymentHistoryModel : BaseNopEntityModel
        {
            public int OrderId { get; set; }

            [NopResourceDisplayName("Merchant.RecurringPayments.History.CustomOrderNumber")]
            public string CustomOrderNumber { get; set; }

            public int RecurringPaymentId { get; set; }

            [NopResourceDisplayName("Merchant.RecurringPayments.History.OrderStatus")]
            public string OrderStatus { get; set; }

            [NopResourceDisplayName("Merchant.RecurringPayments.History.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [NopResourceDisplayName("Merchant.RecurringPayments.History.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [NopResourceDisplayName("Merchant.RecurringPayments.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}