using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class SearchTermReportLineModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [NopResourceDisplayName("Merchant.SearchTermReport.Count")]
        public int Count { get; set; }
    }
}
