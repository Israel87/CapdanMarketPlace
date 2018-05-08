using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Orders;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Orders
{
    public partial class ReturnRequestValidator : BaseNopValidator<ReturnRequestModel>
    {
        public ReturnRequestValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.ReasonForReturn).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ReturnRequests.Fields.ReasonForReturn.Required"));
            RuleFor(x => x.RequestedAction).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ReturnRequests.Fields.RequestedAction.Required"));
        }
    }
}