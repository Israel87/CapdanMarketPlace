using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Polls;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Polls
{
    public partial class PollAnswerValidator : BaseNopValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.Polls.Answers.Fields.Name.Required"));
        }
    }
}