using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Validators.Messages;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    [Validator(typeof(CampaignValidator))]
    public partial class CampaignModel : BaseNopEntityModel
    {
        public CampaignModel()
        {
            this.AvailableStores = new List<SelectListItem>();
            this.AvailableCustomerRoles = new List<SelectListItem>();
            this.AvailableEmailAccounts = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.Subject")]
        public string Subject { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.Body")]
        public string Body { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.Store")]
        public int StoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.CustomerRole")]
        public int CustomerRoleId { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.DontSendBeforeDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DontSendBeforeDate { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.AllowedTokens")]
        public string AllowedTokens { get; set; }

        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.EmailAccount")]
        public int EmailAccountId { get; set; }
        public IList<SelectListItem> AvailableEmailAccounts { get; set; }

        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.Promotions.Campaigns.Fields.TestEmail")]
        public string TestEmail { get; set; }
    }
}