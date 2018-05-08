using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Messages;
using Nop.Core.Domain.Messages;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Messages
{
    public partial class NewsLetterSubscriptionValidator : BaseNopValidator<NewsLetterSubscriptionModel>
    {
        public NewsLetterSubscriptionValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Promotions.NewsLetterSubscriptions.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Merchant.Common.WrongEmail"));

            SetDatabaseValidationRules<NewsLetterSubscription>(dbContext);
        }
    }
}