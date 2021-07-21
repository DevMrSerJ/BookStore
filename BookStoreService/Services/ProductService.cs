using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreService.Services
{
    class ProductService: IProductService
    {
        private readonly IProductRepositories _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepositories productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public IEnumerable<Product> GetAll()
        {
            _logger.LogInformation("Список контактов был запрошен!");
            return _productRepository.GetAll();
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
