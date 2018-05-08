using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Shipping;
using Nop.Core.Domain.Shipping;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Shipping
{
    public partial class DeliveryDateValidator : BaseNopValidator<DeliveryDateModel>
    {
        public DeliveryDateValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Shipping.DeliveryDates.Fields.Name.Required"));

            SetDatabaseValidationRules<DeliveryDate>(dbContext);
        }
    }
}