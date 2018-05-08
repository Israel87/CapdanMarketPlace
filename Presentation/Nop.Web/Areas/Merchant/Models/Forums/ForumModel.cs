using System;
using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Forums;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Forums
{
    [Validator(typeof(ForumValidator))]
    public partial class ForumModel : BaseNopEntityModel
    {
        public ForumModel()
        {
            ForumGroups = new List<ForumGroupModel>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.Forum.Fields.ForumGroupId")]
        public int ForumGroupId { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.Forum.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.Forum.Fields.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.Forum.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Forums.Forum.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public List<ForumGroupModel> ForumGroups { get; set; }
    }
}