using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Vendors;
using Nop.Core.Domain.Vendors;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Vendors
{
    public partial class VendorValidator : BaseNopValidator<VendorModel>
    {
        public VendorValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Vendors.Fields.Name.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Vendors.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Merchant.Common.WrongEmail"));
            RuleFor(x => x.PageSizeOptions).Must(ValidatorUtilities.PageSizeOptionsValidator).WithMessage(localizationService.GetResource("Merchant.Vendors.Fields.PageSizeOptions.ShouldHaveUniqueItems"));
            RuleFor(x => x.PageSize).Must((x, context) =>
            {
                if (!x.AllowCustomersToSelectPageSize && x.PageSize <= 0)
                    return false;

                return true;
            }).WithMessage(localizationService.GetResource("Merchant.Vendors.Fields.PageSize.Positive"));

            SetDatabaseValidationRules<Vendor>(dbContext);
        }
    }
}