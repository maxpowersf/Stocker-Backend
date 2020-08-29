using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Stocker.Application.Repositories;
using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StockerContext _ctx;
        private readonly IMapper _mapper;

        public CategoryRepository(StockerContext ctx, IMapper mapper)
        {
            this._ctx = ctx;
            this._mapper = mapper;
        }

        public async Task<List<Category>> Get()
        {
            var categoryList = await _ctx.Categories.ToListAsync();
            return _mapper.Map<List<Category>>(categoryList);
        }

        public async Task<Category> Get(int id)
        {
            var category = await _ctx.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            return _mapper.Map<Category>(category);
        }

        public async Task Add(Category category)
        {
            var categoryToAdd = _mapper.Map<Entities.Categories>(category);
            await _ctx.AddAsync(categoryToAdd);
        }

        public void Update(Category category)
        {
            Entities.Categories categoryUpdated = _mapper.Map<Entities.Categories>(category);
            _ctx.Categories.Attach(categoryUpdated);
            _ctx.Entry(categoryUpdated).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            var categoryToDelete = await _ctx.Categories.FindAsync(id);
            _ctx.Categories.Remove(categoryToDelete);
        }

        public async Task SaveChanges()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
