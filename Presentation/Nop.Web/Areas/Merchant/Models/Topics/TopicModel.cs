using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Topics
{
    public partial class TopicModel : BaseNopEntityModel, ILocalizedModel<TopicLocalizedModel>
    {
        public TopicModel()
        {
            AvailableTopicTemplates = new List<SelectListItem>();
            Locales = new List<TopicLocalizedModel>();

            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IncludeInSitemap")]
        public bool IncludeInSitemap { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IncludeInTopMenu")]
        public bool IncludeInTopMenu { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IncludeInFooterColumn1")]
        public bool IncludeInFooterColumn1 { get; set; }
        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IncludeInFooterColumn2")]
        public bool IncludeInFooterColumn2 { get; set; }
        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IncludeInFooterColumn3")]
        public bool IncludeInFooterColumn3 { get; set; }
        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.AccessibleWhenStoreClosed")]
        public bool AccessibleWhenStoreClosed { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.IsPasswordProtected")]
        public bool IsPasswordProtected { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Password")]
        public string Password { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.URL")]
        public string Url { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Title")]
        public string Title { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Body")]
        public string Body { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.TopicTemplate")]
        public int TopicTemplateId { get; set; }
        public IList<SelectListItem> AvailableTopicTemplates { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.SeName")]
        public string SeName { get; set; }

        public IList<TopicLocalizedModel> Locales { get; set; }

        //store mapping
        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        //ACL (customer roles)
        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.AclCustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }
    }

    public partial class TopicLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Title")]
        public string Title { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.Body")]
        public string Body { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.Fields.SeName")]
        public string SeName { get; set; }
    }
}