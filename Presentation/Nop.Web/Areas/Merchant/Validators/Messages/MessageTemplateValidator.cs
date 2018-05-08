using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Messages;
using Nop.Core.Domain.Messages;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Messages
{
    public partial class MessageTemplateValidator : BaseNopValidator<MessageTemplateModel>
    {
        public MessageTemplateValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.MessageTemplates.Fields.Subject.Required"));
            RuleFor(x => x.Body).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.MessageTemplates.Fields.Body.Required"));

            SetDatabaseValidationRules<MessageTemplate>(dbContext);
        }
    }
}