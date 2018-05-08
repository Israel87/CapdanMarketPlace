using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Settings
{
    public class AllSettingsListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Settings.AllSettings.SearchSettingName")]
        public string SearchSettingName { get; set; }
        [NopResourceDisplayName("Merchant.Configuration.Settings.AllSettings.SearchSettingValue")]
        public string SearchSettingValue { get; set; }
    }
}