using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Common;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    [Validator(typeof(AddressAttributeValidator))]
    public partial class AddressAttributeModel : BaseNopEntityModel, ILocalizedModel<AddressAttributeLocalizedModel>
    {
        public AddressAttributeModel()
        {
            Locales = new List<AddressAttributeLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<AddressAttributeLocalizedModel> Locales { get; set; }
    }

    public partial class AddressAttributeLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Address.AddressAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}