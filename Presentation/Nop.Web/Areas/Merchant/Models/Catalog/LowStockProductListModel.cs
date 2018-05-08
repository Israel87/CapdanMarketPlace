using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    public class LowStockProductListModel : BaseNopModel
    {
        public LowStockProductListModel()
        {
            AvailablePublishedOptions = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Catalog.LowStockReport.SearchPublished")]
        public int SearchPublishedId { get; set; }
        public IList<SelectListItem> AvailablePublishedOptions { get; set; }
    }
}