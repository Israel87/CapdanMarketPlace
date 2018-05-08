using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Plugins;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Plugins
{
    public partial class PluginValidator : BaseNopValidator<PluginModel>
    {
        public PluginValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendlyName).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}