using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Models.Common;
using Nop.Web.Areas.Merchant.Validators.Shipping;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Shipping
{
    [Validator(typeof(WarehouseValidator))]
    public partial class WarehouseModel : BaseNopEntityModel
    {
        public WarehouseModel()
        {
            this.Address = new AddressModel();
        }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Warehouses.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Warehouses.Fields.MerchantComment")]
        public string MerchantComment { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Warehouses.Fields.Address")]
        public AddressModel Address { get; set; }
    }
}