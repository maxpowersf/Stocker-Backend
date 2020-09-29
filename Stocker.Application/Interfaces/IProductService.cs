using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> Get(int categoryTypeId, bool excludehighstock, bool excludeinactive);
        Task<Product> Get(int id);
        Task Add(Product product);
        Task Update(Product product);
        Task UpdateAll(List<Product> products);
        Task Delete(int id);
    }
}
