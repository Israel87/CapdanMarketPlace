using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Templates;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Templates
{
    public partial class ManufacturerTemplateValidator : BaseNopValidator<ManufacturerTemplateModel>
    {
        public ManufacturerTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Manufacturer.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Manufacturer.ViewPath.Required"));
        }
    }
}