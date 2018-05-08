using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Core.Domain.Common;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Common
{
    public partial class AddressAttributeValidator : BaseNopValidator<AddressAttributeModel>
    {
        public AddressAttributeValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Address.AddressAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<AddressAttribute>(dbContext);
        }
    }
}