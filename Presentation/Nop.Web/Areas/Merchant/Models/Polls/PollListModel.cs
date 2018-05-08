using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Polls
{
    public partial class PollListModel : BaseNopModel
    {
        #region Ctor

        public PollListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Ctor

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        #endregion
    }
}