using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Affiliates
{
    public partial class AffiliateModel : BaseNopEntityModel
    {
        public AffiliateModel()
        {
            Address = new AddressModel();
            AffiliatedOrderList = new AffiliatedOrderListModel();
        }

        [NopResourceDisplayName("Merchant.Affiliates.Fields.URL")]
        public string Url { get; set; }
        
        [NopResourceDisplayName("Merchant.Affiliates.Fields.MerchantComment")]
        public string MerchantComment { get; set; }

        [NopResourceDisplayName("Merchant.Affiliates.Fields.FriendlyUrlName")]
        public string FriendlyUrlName { get; set; }
        
        [NopResourceDisplayName("Merchant.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        public AffiliatedOrderListModel AffiliatedOrderList { get; set; }

        #region Nested classes

        public partial class AffiliatedOrderListModel : BaseNopModel
        {
            public AffiliatedOrderListModel()
            {
                AvailableOrderStatuses = new List<SelectListItem>();
                AvailablePaymentStatuses = new List<SelectListItem>();
                AvailableShippingStatuses = new List<SelectListItem>();
            }

            public int AffliateId { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.OrderStatus")]
            public int OrderStatusId { get; set; }
            [NopResourceDisplayName("Merchant.Affiliates.Orders.PaymentStatus")]
            public int PaymentStatusId { get; set; }
            [NopResourceDisplayName("Merchant.Affiliates.Orders.ShippingStatus")]
            public int ShippingStatusId { get; set; }

            public IList<SelectListItem> AvailableOrderStatuses { get; set; }
            public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
            public IList<SelectListItem> AvailableShippingStatuses { get; set; }
        }

        public partial class AffiliatedOrderModel : BaseNopEntityModel
        {
            public override int Id { get; set; }
            [NopResourceDisplayName("Merchant.Affiliates.Orders.CustomOrderNumber")]
            public string CustomOrderNumber { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.OrderStatus")]
            public string OrderStatus { get; set; }
            [NopResourceDisplayName("Merchant.Affiliates.Orders.OrderStatus")]
            public int OrderStatusId { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.OrderTotal")]
            public string OrderTotal { get; set; }

            [NopResourceDisplayName("Merchant.Affiliates.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AffiliatedCustomerModel : BaseNopEntityModel
        {
            [NopResourceDisplayName("Merchant.Affiliates.Customers.Name")]
            public string Name { get; set; }
        }

        #endregion
    }
}