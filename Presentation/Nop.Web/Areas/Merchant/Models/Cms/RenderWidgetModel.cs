﻿using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Cms
{
    public partial class RenderWidgetModel : BaseNopModel
    {
        public string WidgetViewComponentName { get; set; }
        public object WidgetViewComponentArguments { get; set; }
    }
}