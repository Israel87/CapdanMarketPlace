using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Messages;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    [Validator(typeof(NewsLetterSubscriptionValidator))]
    public partial class NewsLetterSubscriptionModel : BaseNopEntityModel
    {
        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.Fields.Email")]
        public string Email { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.Fields.Active")]
        public bool Active { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.Fields.Store")]
        public string StoreName { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.NewsLetterSubscriptions.Fields.CreatedOn")]
        public string CreatedOn { get; set; }
    }
}