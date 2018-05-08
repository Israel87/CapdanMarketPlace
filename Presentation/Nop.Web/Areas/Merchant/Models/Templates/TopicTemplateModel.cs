using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Templates;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Templates
{
    [Validator(typeof(TopicTemplateValidator))]
    public partial class TopicTemplateModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.Templates.Topic.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Topic.ViewPath")]
        public string ViewPath { get; set; }

        [NopResourceDisplayName("Merchant.System.Templates.Topic.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}