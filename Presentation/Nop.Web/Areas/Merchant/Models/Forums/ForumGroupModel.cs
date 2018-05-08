using System;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Forums;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Forums
{
    [Validator(typeof(ForumGroupValidator))]
    public partial class ForumGroupModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.ContentManagement.Forums.ForumGroup.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.ForumGroup.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.ForumGroup.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}