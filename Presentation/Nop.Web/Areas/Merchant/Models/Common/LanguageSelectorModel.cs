using System.Collections.Generic;
using Nop.Web.Areas.Merchant.Models.Localization;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class LanguageSelectorModel : BaseNopModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }
    }
}