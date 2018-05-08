using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Settings;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Settings
{
    public partial class ReturnRequestReasonValidator : BaseNopValidator<ReturnRequestReasonModel>
    {
        public ReturnRequestReasonValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Settings.Order.ReturnRequestReasons.Name.Required"));
        }
    }
}