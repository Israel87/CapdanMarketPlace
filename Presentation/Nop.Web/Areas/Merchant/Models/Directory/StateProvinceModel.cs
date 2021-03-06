﻿using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Directory;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Directory
{
    [Validator(typeof(StateProvinceValidator))]
    public partial class StateProvinceModel : BaseNopEntityModel, ILocalizedModel<StateProvinceLocalizedModel>
    {
        public StateProvinceModel()
        {
            Locales = new List<StateProvinceLocalizedModel>();
        }
        public int CountryId { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Countries.States.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Countries.States.Fields.Abbreviation")]
        public string Abbreviation { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Countries.States.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Countries.States.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<StateProvinceLocalizedModel> Locales { get; set; }
    }

    public partial class StateProvinceLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }
        
        [NopResourceDisplayName("Merchant.Configuration.Countries.States.Fields.Name")]
        public string Name { get; set; }
    }
}