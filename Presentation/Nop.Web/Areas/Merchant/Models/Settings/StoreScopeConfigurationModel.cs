using System.Collections.Generic;
using Nop.Web.Areas.Merchant.Models.Stores;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Settings
{
    public partial class StoreScopeConfigurationModel : BaseNopModel
    {
        public StoreScopeConfigurationModel()
        {
            Stores = new List<StoreModel>();
        }

        public int StoreId { get; set; }
        public IList<StoreModel> Stores { get; set; }
    }
}