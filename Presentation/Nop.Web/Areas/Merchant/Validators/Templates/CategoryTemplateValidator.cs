using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Templates;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Templates
{
    public partial class CategoryTemplateValidator : BaseNopValidator<CategoryTemplateModel>
    {
        public CategoryTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Category.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Category.ViewPath.Required"));
        }
    }
}