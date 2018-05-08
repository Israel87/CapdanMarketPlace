using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Messages;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Messages
{
    public partial class CampaignValidator : BaseNopValidator<CampaignModel>
    {
        public CampaignValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Promotions.Campaigns.Fields.Name.Required"));

            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Promotions.Campaigns.Fields.Subject.Required"));

            RuleFor(x => x.Body).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Promotions.Campaigns.Fields.Body.Required"));
        }
    }
}