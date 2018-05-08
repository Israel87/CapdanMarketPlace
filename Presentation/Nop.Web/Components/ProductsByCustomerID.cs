using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Customers;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Components
{
    public class ProductsByCustomerIDViewComponent: NopViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICustomerAttributeService _customerAttributeService;
        private readonly ICustomerService _customerService;


        public ProductsByCustomerIDViewComponent(IProductService productService, ICustomerAttributeService customerAttributeService, 
            ICustomerService customerService)
        {
            _productService = productService;
            _customerAttributeService = customerAttributeService;
            _customerService = customerService;
        }


        public IViewComponentResult Invoke()
        {
            //string civn = "";
            //var customermodel = _customerService.GetMerchantCustomerByCIVN(civn);
            //var model = _productService.GetAllProductsByMerchantsAsCustomerID(customermodel.Id);

            return View();

        }
    }
}
