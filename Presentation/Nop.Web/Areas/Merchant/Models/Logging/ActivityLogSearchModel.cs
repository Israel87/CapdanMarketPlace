using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Logging
{
    public partial class ActivityLogSearchModel : BaseNopModel
    {
        public ActivityLogSearchModel()
        {
            ActivityLogType = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.ActivityLogType")]
        public int ActivityLogTypeId { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ActivityLog.ActivityLog.Fields.ActivityLogType")]
        public IList<SelectListItem> ActivityLogType { get; set; }
        
        [NopResourceDisplayName("Merchant.Customers.Customers.ActivityLog.IpAddress")]
        public string IpAddress { get; set; }
    }
}