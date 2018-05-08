using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    public partial class MessageTemplateListModel : BaseNopModel
    {
        public MessageTemplateListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.MessageTemplates.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}