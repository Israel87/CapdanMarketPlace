using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Components
{
    public class MerchantsAtHomePageViewComponent : NopViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly ICustomerAttributeService _customerAttributeService;

        public MerchantsAtHomePageViewComponent(ICatalogModelFactory catalogModelFactory, ICustomerService customerService, IProductService productservice, ICustomerAttributeService customerAttributeService)
        {
            _catalogModelFactory = catalogModelFactory;
            _customerService = customerService;
            _productService = productservice;
            _customerAttributeService = customerAttributeService;

        }

        public IViewComponentResult Invoke()
        {
            // Get all merchants 
            var merchants =  _customerService.GetAllMerchants();
          var arrayOfNames = new List<string>();

            foreach (var singleMerchant in merchants)
            {
                var merchantID = merchants.SingleOrDefault(p => p.Id == singleMerchant.Id).Id;
                var merchantDetails = _customerService.GetCustomerById(merchantID);
                var fullname = merchantDetails.GetFullName();
                singleMerchant.SystemName = fullname;
                arrayOfNames.Add(fullname);
            }
            ViewBag.MerchantName = merchants;
                //arrayOfNames;

            if (!merchants.Any())
                return Content("");
            return View(merchants);
        }
    }
}
