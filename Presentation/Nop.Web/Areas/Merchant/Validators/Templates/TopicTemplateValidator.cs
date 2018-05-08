using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Templates;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Templates
{
    public partial class TopicTemplateValidator : BaseNopValidator<TopicTemplateModel>
    {
        public TopicTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Topic.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Merchant.System.Templates.Topic.ViewPath.Required"));
        }
    }
}