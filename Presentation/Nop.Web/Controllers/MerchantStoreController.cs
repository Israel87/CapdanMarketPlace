using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Services.Customers;

namespace Nop.Web.Controllers
{
    public class MerchantStoreController : BasePublicController
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;


        public MerchantStoreController(ICustomerService customerService, IProductService productService)
        {
            _customerService = customerService;
            _productService = productService;
        }
        public IActionResult Index(string civn)
        {
            TempData["CIVN"] = civn;
            var customermodel = _customerService.GetMerchantCustomerByCIVN(civn);
            var model = _productService.GetAllProductsByMerchantsAsCustomerID(customermodel.Id);

            return View(model);

        }
    }
}
