using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Plugins
{
    public partial class PluginListModel : BaseNopModel
    {
        public PluginListModel()
        {
            AvailableLoadModes = new List<SelectListItem>();
            AvailableGroups = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Configuration.Plugins.LoadMode")]
        public int SearchLoadModeId { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.Plugins.Group")]
        public string SearchGroup { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Plugins.LoadMode")]
        public IList<SelectListItem> AvailableLoadModes { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.Plugins.Group")]
        public IList<SelectListItem> AvailableGroups { get; set; }
    }
}