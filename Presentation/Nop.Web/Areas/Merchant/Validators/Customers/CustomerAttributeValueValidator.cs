using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Customers;
using Nop.Core.Domain.Customers;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Customers
{
    public partial class CustomerAttributeValueValidator : BaseNopValidator<CustomerAttributeValueModel>
    {
        public CustomerAttributeValueValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Customers.CustomerAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerAttributeValue>(dbContext);
        }
    }
}