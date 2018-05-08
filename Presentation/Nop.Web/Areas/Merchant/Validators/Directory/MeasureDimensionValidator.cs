using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Directory;
using Nop.Core.Domain.Directory;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Directory
{
    public partial class MeasureDimensionValidator : BaseNopValidator<MeasureDimensionModel>
    {
        public MeasureDimensionValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.SystemKeyword.Required"));

            SetDatabaseValidationRules<MeasureDimension>(dbContext);
        }
    }
}