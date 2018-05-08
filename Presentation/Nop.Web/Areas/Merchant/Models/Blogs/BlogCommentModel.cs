using System;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Blogs
{
    public partial class BlogCommentModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public int BlogPostId { get; set; }
        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public string BlogPostTitle { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.Customer")]
        public int CustomerId { get; set; }
        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }
        
        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.Comment")]
        public string Comment { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.StoreName")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Blog.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

    }
}