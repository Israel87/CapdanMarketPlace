using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Tasks;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Tasks
{
    [Validator(typeof(ScheduleTaskValidator))]
    public partial class ScheduleTaskModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.ScheduleTasks.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.Seconds")]
        public int Seconds { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.Enabled")]
        public bool Enabled { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.StopOnError")]
        public bool StopOnError { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.LastStart")]
        public string LastStartUtc { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.LastEnd")]
        public string LastEndUtc { get; set; }

        [NopResourceDisplayName("Merchant.System.ScheduleTasks.LastSuccess")]
        public string LastSuccessUtc { get; set; }
    }
}