using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreService.Services
{
    /// <summary>
    /// Контроллер продуктов.
    /// </summary>
    public class CatalogController : ControllerBase
    {
        private readonly IProductService _productService;

        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }
    }
}
