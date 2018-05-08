using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Templates;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Templates
{
    [Validator(typeof(ManufacturerTemplateValidator))]
    public partial class ManufacturerTemplateModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.Templates.Manufacturer.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Manufacturer.ViewPath")]
        public string ViewPath { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Manufacturer.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}