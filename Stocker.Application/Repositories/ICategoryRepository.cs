using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> Get();
        Task<Category> Get(int id);
        Task Add(Category category);
        void Update(Category category);
        Task Delete(int id);
        Task SaveChanges();
    }
}
