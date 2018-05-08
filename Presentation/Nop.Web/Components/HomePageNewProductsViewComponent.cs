using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Catalog;
using Nop.Services.Catalog;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nop.Web.Components
{
    public class HomePageNewProductsViewComponent : NopViewComponent
    {
        private readonly IProductModelFactory _productModelFactory;
        private readonly IProductService _productService;

        public HomePageNewProductsViewComponent(
            IProductModelFactory productModelFactory,
            IProductService productService)
        {
            this._productModelFactory = productModelFactory;
            this._productService = productService;
        }

        public IViewComponentResult Invoke(int? productThumbPictureSize)
        {
            //var products = _productService.SearchProducts(markedAsNewOnly: true).ToList();
            var products = _productService.SearchProducts().ToList();

            if (!products.Any())
                return Content("");

            var model = _productModelFactory.PrepareProductOverviewModels(products, true, true, productThumbPictureSize).ToList();

            return View(model);
        }
    }
}
