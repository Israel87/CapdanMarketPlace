using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Validators.Polls;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Polls
{
    [Validator(typeof(PollValidator))]
    public partial class PollModel : BaseNopEntityModel
    {
        public PollModel()
        {
            this.AvailableLanguages = new List<SelectListItem>();
            this.AvailableStores = new List<SelectListItem>();
            this.SelectedStoreIds = new List<int>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.Language")]
        public int LanguageId { get; set; }
        public IList<SelectListItem> AvailableLanguages { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.Language")]
        public string LanguageName { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.AllowGuestsToVote")]
        public bool AllowGuestsToVote { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDate { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDate { get; set; }
        
        [NopResourceDisplayName("Merchant.ContentManagement.Polls.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}