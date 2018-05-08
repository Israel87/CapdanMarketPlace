using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Localization
{
    [Validator(typeof(LanguageResourceValidator))]
    public partial class LanguageResourceModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Languages.Resources.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Languages.Resources.Fields.Value")]
        public string Value { get; set; }

        public int LanguageId { get; set; }
    }
}