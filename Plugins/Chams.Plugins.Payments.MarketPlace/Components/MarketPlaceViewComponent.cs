using Chams.Plugin.Payments.MarketPlace.Model;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Localization;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chams.Plugin.Payments.MarketPlace.Components
{
    [ViewComponent(Name = "ChamsSwitchGateway")]
    public class MarketPlaceViewComponent : NopViewComponent
    {
        private readonly MarketPlaceChamsSwitchSettings _marketplacechamsswitchsettings;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;



        public MarketPlaceViewComponent(MarketPlaceChamsSwitchSettings marketplacechamsswitchsettings,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            this._marketplacechamsswitchsettings = marketplacechamsswitchsettings;
            this._storeContext = storeContext;
            this._workContext = workContext;
        }

        public IViewComponentResult Invoke()
        {
            var model = new PaymentInfoModel
            {
                DescriptionText = _marketplacechamsswitchsettings.GetLocalizedSetting(x => x.DescriptionText,
                  _workContext.WorkingLanguage.Id, _storeContext.CurrentStore.Id),
                PBFPubKey = _marketplacechamsswitchsettings.GetLocalizedSetting(x => x.PBFPubKey,
                _workContext.WorkingLanguage.Id, _storeContext.CurrentStore.Id),
                LogoUrl = _marketplacechamsswitchsettings.GetLocalizedSetting(x => x.LogoUrl, 
                _workContext.WorkingLanguage.Id, _storeContext.CurrentStore.Id)
              
            };

            return View("~/Plugins/Payments.MarketPlace/Views/ChamsSwitchGateway.cshtml");
        }
    }
}
