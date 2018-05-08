using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Localization;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Localization
{
    public partial class LanguageResourceValidator : BaseNopValidator<LanguageResourceModel>
    {
        public LanguageResourceValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Languages.Resources.Fields.Name.Required"));
            RuleFor(x => x.Value).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Languages.Resources.Fields.Value.Required"));
        }
    }
}