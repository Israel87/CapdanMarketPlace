﻿using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Messages;
using Nop.Core.Domain.Messages;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Messages
{
    public partial class EmailAccountValidator : BaseNopValidator<EmailAccountModel>
    {
        public EmailAccountValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Merchant.Common.WrongEmail"));
            
            RuleFor(x => x.DisplayName).NotEmpty();

            SetDatabaseValidationRules<EmailAccount>(dbContext);
        }
    }
}