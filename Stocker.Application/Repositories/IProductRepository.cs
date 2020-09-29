using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> Get(int categoryTypeId, bool excludehighstock, bool excludeinactive);
        Task<Product> Get(int id);
        Task Add(Product product);
        void Update(Product product);
        Task Delete(int id);
        Task SaveChanges();
    }
}
