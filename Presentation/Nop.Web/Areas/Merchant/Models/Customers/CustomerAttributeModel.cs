using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Customers;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    [Validator(typeof(CustomerAttributeValidator))]
    public partial class CustomerAttributeModel : BaseNopEntityModel, ILocalizedModel<CustomerAttributeLocalizedModel>
    {
        public CustomerAttributeModel()
        {
            Locales = new List<CustomerAttributeLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<CustomerAttributeLocalizedModel> Locales { get; set; }
    }

    public partial class CustomerAttributeLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Customers.CustomerAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}