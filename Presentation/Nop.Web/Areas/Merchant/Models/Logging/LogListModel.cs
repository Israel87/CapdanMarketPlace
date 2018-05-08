﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Logging
{
    public partial class LogListModel : BaseNopModel
    {
        public LogListModel()
        {
            AvailableLogLevels = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.System.Log.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.List.Message")]
        public string Message { get; set; }

        [NopResourceDisplayName("Merchant.System.Log.List.LogLevel")]
        public int LogLevelId { get; set; }

        public IList<SelectListItem> AvailableLogLevels { get; set; }
    }
}