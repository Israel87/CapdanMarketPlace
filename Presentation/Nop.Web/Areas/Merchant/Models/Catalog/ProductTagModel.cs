using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Catalog;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    [Validator(typeof(ProductTagValidator))]
    public partial class ProductTagModel : BaseNopEntityModel, ILocalizedModel<ProductTagLocalizedModel>
    {
        public ProductTagModel()
        {
            Locales = new List<ProductTagLocalizedModel>();
        }
        [NopResourceDisplayName("Merchant.Catalog.ProductTags.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductTags.Fields.ProductCount")]
        public int ProductCount { get; set; }

        public IList<ProductTagLocalizedModel> Locales { get; set; }
    }

    public partial class ProductTagLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.ProductTags.Fields.Name")]
        public string Name { get; set; }
    }
}