using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Cms
{
    public partial class WidgetModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.ContentManagement.Widgets.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Widgets.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Widgets.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Widgets.Fields.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Widgets.Configure")]
        public string ConfigurationUrl { get; set; }

        public string WidgetViewComponentName { get; set; }
        public RouteValueDictionary WidgetViewComponentArguments { get; set; }
    }
}