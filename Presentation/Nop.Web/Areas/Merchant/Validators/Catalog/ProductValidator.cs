using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Catalog;
using Nop.Core.Domain.Catalog;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Catalog
{
    public partial class ProductValidator : BaseNopValidator<ProductModel>
    {
        public ProductValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Catalog.Products.Fields.Name.Required"));

            SetDatabaseValidationRules<Product>(dbContext);
        }
    }
}