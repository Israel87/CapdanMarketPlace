﻿using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Orders;
using Nop.Core.Domain.Orders;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Orders
{
    public partial class CheckoutAttributeValueValidator : BaseNopValidator<CheckoutAttributeValueModel>
    {
        public CheckoutAttributeValueValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Catalog.Attributes.CheckoutAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<CheckoutAttributeValue>(dbContext);
        }
    }
}