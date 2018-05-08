using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Messages;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    [Validator(typeof(TestMessageTemplateValidator))]
    public partial class TestMessageTemplateModel : BaseNopEntityModel
    {
        public TestMessageTemplateModel()
        {
            Tokens = new List<string>();
        }

        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.MessageTemplates.Test.Tokens")]
        public List<string> Tokens { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.MessageTemplates.Test.SendTo")]
        public string SendTo { get; set; }
    }
}