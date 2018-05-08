using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Shipping;
using Nop.Core.Domain.Shipping;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Shipping
{
    public partial class ShippingMethodValidator : BaseNopValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Shipping.Methods.Fields.Name.Required"));

            SetDatabaseValidationRules<ShippingMethod>(dbContext);
        }
    }
}