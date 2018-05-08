using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Common;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    [Validator(typeof(AddressAttributeValueValidator))]
    public partial class AddressAttributeValueModel : BaseNopEntityModel, ILocalizedModel<AddressAttributeValueLocalizedModel>
    {
        public AddressAttributeValueModel()
        {
            Locales = new List<AddressAttributeValueLocalizedModel>();
        }

        public int AddressAttributeId { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<AddressAttributeValueLocalizedModel> Locales { get; set; }
    }

    public partial class AddressAttributeValueLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}