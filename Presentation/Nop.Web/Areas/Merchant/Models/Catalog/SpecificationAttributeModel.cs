using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Catalog;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    [Validator(typeof(SpecificationAttributeValidator))]
    public partial class SpecificationAttributeModel : BaseNopEntityModel, ILocalizedModel<SpecificationAttributeLocalizedModel>
    {
        public SpecificationAttributeModel()
        {
            Locales = new List<SpecificationAttributeLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Catalog.Attributes.SpecificationAttributes.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Attributes.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}


        public IList<SpecificationAttributeLocalizedModel> Locales { get; set; }
    }

    public partial class SpecificationAttributeLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Attributes.SpecificationAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}