using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreService.Services
{
    public interface IProductService: IDisposable
    {
        /// <summary>
        /// Вернуть все книги.
        /// </summary>
        /// <returns>Список книг.</returns>
        IEnumerable<Product> GetAll();
    }
}
