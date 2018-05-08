using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class UrlRecordListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.System.SeNames.Name")]
        public string SeName { get; set; }
    }
}