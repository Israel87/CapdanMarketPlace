using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    public partial class ManufacturerListModel : BaseNopModel
    {
        public ManufacturerListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.List.SearchManufacturerName")]
        public string SearchManufacturerName { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Manufacturers.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}