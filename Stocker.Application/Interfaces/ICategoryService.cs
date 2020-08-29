using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> Get();
        Task<Category> Get(int id);
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(int id);
    }
}
