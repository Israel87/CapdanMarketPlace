using FluentValidation;
using Nop.Web.Areas.Merchant.Models.Vendors;
using Nop.Core.Domain.Vendors;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.Vendors
{
    public partial class VendorAttributeValidator : BaseNopValidator<VendorAttributeModel>
    {
        public VendorAttributeValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Merchant.Vendors.VendorAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<VendorAttribute>(dbContext);
        }
    }
}