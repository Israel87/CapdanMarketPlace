using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Tax;
using Nop.Core.Domain.Tax;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Tax
{
    public partial class TaxCategoryValidator : BaseNopValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Tax.Categories.Fields.Name.Required"));

            SetDatabaseValidationRules<TaxCategory>(dbContext);
        }
    }
}