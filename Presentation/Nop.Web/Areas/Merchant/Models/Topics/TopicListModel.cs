using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Topics
{
    public partial class TopicListModel : BaseNopModel
    {
        public TopicListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Topics.List.SearchKeywords")]
        public string SearchKeywords { get; set; }
    }
}