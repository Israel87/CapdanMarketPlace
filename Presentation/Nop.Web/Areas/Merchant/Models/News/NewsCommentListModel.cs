﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.News
{
    public partial class NewsCommentListModel : BaseNopModel
    {
        public NewsCommentListModel()
        {
            AvailableApprovedOptions = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.ContentManagement.News.Comments.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.News.Comments.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.News.Comments.List.SearchText")]
        public string SearchText { get; set; }

        [NopResourceDisplayName("Merchant.ContentManagement.News.Comments.List.SearchApproved")]
        public int SearchApprovedId { get; set; }

        public IList<SelectListItem> AvailableApprovedOptions { get; set; }
    }
}