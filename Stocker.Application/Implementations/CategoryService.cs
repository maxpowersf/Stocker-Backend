using Stocker.Application.Interfaces;
using Stocker.Application.Repositories;
using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public Task<List<Category>> Get()
        {
            return _categoryRepository.Get();
        }

        public Task<Category> Get(int id)
        {
            return _categoryRepository.Get(id);
        }

        public async Task Add(Category category)
        {
            await _categoryRepository.Add(category);
            await _categoryRepository.SaveChanges();
        }

        public async Task Update(Category category)
        {
            _categoryRepository.Update(category);
            await _categoryRepository.SaveChanges();
        }

        public async Task Delete(int id)
        {
            await _categoryRepository.Delete(id);
            await _categoryRepository.SaveChanges();
        }
    }
}
