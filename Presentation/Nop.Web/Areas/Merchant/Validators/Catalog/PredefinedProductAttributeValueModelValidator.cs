using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Catalog;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Catalog
{
    public partial class PredefinedProductAttributeValueModelValidator : BaseNopValidator<PredefinedProductAttributeValueModel>
    {
        public PredefinedProductAttributeValueModelValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Merchant.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name.Required"));
        }
    }
}