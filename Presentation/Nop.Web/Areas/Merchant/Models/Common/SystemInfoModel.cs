using System;
using System.Collections.Generic;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class SystemInfoModel : BaseNopModel
    {
        public SystemInfoModel()
        {
            this.Headers = new List<HeaderModel>();
            this.LoadedAssemblies = new List<LoadedAssembly>();
        }

        [NopResourceDisplayName("Merchant.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.IsFullTrust")]
        public string IsFullTrust { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.NopVersion")]
        public string NopVersion { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.CurrentUserTime")]
        public DateTime CurrentUserTime { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.HTTPHOST")]
        public string HttpHost { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.Headers")]
        public IList<HeaderModel> Headers { get; set; }

        [NopResourceDisplayName("Merchant.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        public partial class HeaderModel : BaseNopModel
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public partial class LoadedAssembly : BaseNopModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
            public bool IsDebug { get; set; }
            public DateTime? BuildDate { get; set; }
        }
    }
}