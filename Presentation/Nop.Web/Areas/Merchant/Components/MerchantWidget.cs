﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Nop.Services.Cms;
using Nop.Web.Areas.Merchant.Models.Cms;
using Nop.Web.Framework.Components;

namespace Nop.Web.Areas.Merchant.Components
{
    public class MerchantWidgetViewComponent : NopViewComponent
    {
        private readonly IWidgetService _widgetService;

        public MerchantWidgetViewComponent(IWidgetService widgetService)
        {
            this._widgetService = widgetService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData = null)
        {
            var model = new List<RenderWidgetModel>();

            //add widget zone to view component arguments
            additionalData = new RouteValueDictionary()
            {
                { "widgetZone", widgetZone },
                { "additionalData", additionalData }
            };

            var widgets = _widgetService.LoadActiveWidgetsByWidgetZone(widgetZone);
            foreach (var widget in widgets)
            {
                model.Add(new RenderWidgetModel
                {
                    WidgetViewComponentName = widget.GetWidgetViewComponentName(widgetZone),
                    WidgetViewComponentArguments = additionalData
                });
            }

            //no data?
            if (!model.Any())
                return Content("");

            return View(model);
        }
    }
}