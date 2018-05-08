using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Templates;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Templates
{
    [Validator(typeof(ProductTemplateValidator))]
    public partial class ProductTemplateModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.Templates.Product.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Product.ViewPath")]
        public string ViewPath { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Product.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Product.IgnoredProductTypes")]
        public string IgnoredProductTypes { get; set; }
    }
}