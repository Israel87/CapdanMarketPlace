using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Core.Domain.Common;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Common
{
    public partial class AddressAttributeValueValidator : BaseNopValidator<AddressAttributeValueModel>
    {
        public AddressAttributeValueValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Address.AddressAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<AddressAttributeValue>(dbContext);
        }
    }
}