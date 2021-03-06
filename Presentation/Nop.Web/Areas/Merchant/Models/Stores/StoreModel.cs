﻿using System.Collections.Generic;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Merchant.Validators.Stores;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Stores
{
    [Validator(typeof(StoreValidator))]
    public partial class StoreModel : BaseNopEntityModel, ILocalizedModel<StoreLocalizedModel>
    {
        public StoreModel()
        {
            Locales = new List<StoreLocalizedModel>();
            AvailableLanguages = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.Url")]
        public string Url { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.SslEnabled")]
        public virtual bool SslEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.Hosts")]
        public string Hosts { get; set; }

        //default language
        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.DefaultLanguage")]
        public int DefaultLanguageId { get; set; }
        public IList<SelectListItem> AvailableLanguages { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.CompanyName")]
        public string CompanyName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.CompanyAddress")]
        public string CompanyAddress { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.CompanyPhoneNumber")]
        public string CompanyPhoneNumber { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.CompanyVat")]
        public string CompanyVat { get; set; }
        
        public IList<StoreLocalizedModel> Locales { get; set; }
    }

    public partial class StoreLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Stores.Fields.Name")]
        public string Name { get; set; }
    }
}