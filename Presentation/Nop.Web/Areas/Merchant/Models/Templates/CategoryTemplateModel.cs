using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Templates;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Templates
{
    [Validator(typeof(CategoryTemplateValidator))]
    public partial class CategoryTemplateModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.Templates.Category.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Category.ViewPath")]
        public string ViewPath { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Category.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}