using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreService.Services
{
    /// <summary>
    /// Репозиторий продуктов.
    /// </summary>
    interface IProductRepositories
    {
        /// <summary>
        /// Вернуть все продукты.
        /// </summary>
        /// <returns>Список продуктов.</returns>
        public IEnumerable<Product> GetAll();
    }
}
