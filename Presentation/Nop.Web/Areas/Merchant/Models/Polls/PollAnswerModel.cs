using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Polls;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Polls
{
    [Validator(typeof(PollAnswerValidator))]
    public partial class PollAnswerModel : BaseNopEntityModel
    {
        public int PollId { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Answers.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Answers.Fields.NumberOfVotes")]
        public int NumberOfVotes { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Answers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}