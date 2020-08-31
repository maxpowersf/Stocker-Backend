using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> Get(bool excludehighstock);
        Task<Product> Get(int id);
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
    }
}
