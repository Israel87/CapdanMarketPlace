using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Localization
{
    public class LanguageResourcesListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Languages.Resources.SearchResourceName")]
        public string SearchResourceName { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.Languages.Resources.SearchResourceValue")]
        public string SearchResourceValue { get; set; }
    }
}