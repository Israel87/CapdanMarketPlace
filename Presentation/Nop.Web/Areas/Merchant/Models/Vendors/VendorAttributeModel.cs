using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Vendors;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Vendors
{
    [Validator(typeof(VendorAttributeValidator))]
    public partial class VendorAttributeModel : BaseNopEntityModel, ILocalizedModel<VendorAttributeLocalizedModel>
    {
        public VendorAttributeModel()
        {
            Locales = new List<VendorAttributeLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<VendorAttributeLocalizedModel> Locales { get; set; }
    }

    public partial class VendorAttributeLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Vendors.VendorAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}