using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreService.Services
{
    /// <summary>
    /// Репозиторий продуктов на основе JSON файла.
    /// </summary>
    public class JsonProductRepositories: IProductRepositories
    {
        private readonly FileInfo _fileInfo;

        public JsonProductRepositories(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        /// <inheritdoc/>
        public IEnumerable<Product> GetAll()
        {
            return JsonConvert.DeserializeObject<Product[]>(File.ReadAllText(_fileInfo.FullName));
        }
    }
}
