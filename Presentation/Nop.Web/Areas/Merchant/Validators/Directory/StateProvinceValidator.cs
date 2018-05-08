using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Directory;
using Nop.Core.Domain.Directory;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Directory
{
    public partial class StateProvinceValidator : BaseNopValidator<StateProvinceModel>
    {
        public StateProvinceValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Countries.States.Fields.Name.Required"));

            SetDatabaseValidationRules<StateProvince>(dbContext);
        }
    }
}