using System;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Orders;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Orders
{
    [Validator(typeof(ReturnRequestValidator))]
    public partial class ReturnRequestModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.CustomNumber")]
        public string CustomNumber { get; set; }
        
        public int OrderId { get; set; }
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Customer")]
        public string CustomerInfo { get; set; }

        public int ProductId { get; set; }
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Product")]
        public string ProductName { get; set; }
        public string AttributeInfo { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Quantity")]
        public int Quantity { get; set; }
        
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.ReasonForReturn")]
        public string ReasonForReturn { get; set; }
        
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.RequestedAction")]
        public string RequestedAction { get; set; }
        
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.CustomerComments")]
        public string CustomerComments { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.UploadedFile")]
        public Guid UploadedFileGuid { get; set; }
        
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.StaffNotes")]
        public string StaffNotes { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Status")]
        public int ReturnRequestStatusId { get; set; }
        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.Status")]
        public string ReturnRequestStatusStr { get; set; }

        [NopResourceDisplayName("Merchant.ReturnRequests.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}