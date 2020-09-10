using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Stocker.Application.Repositories;
using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StockerContext _ctx;
        private readonly IMapper _mapper;

        public ProductRepository(StockerContext ctx, IMapper mapper)
        {
            this._ctx = ctx;
            this._mapper = mapper;
        }

        public async Task<List<Product>> Get(bool excludehighstock)
        {
            var productList = await _ctx.Products
                                            .Include(e => e.Category)
                                            .Where(e => e.Stock < e.MinimumAccepted || !excludehighstock)
                                            .ToListAsync();

            return _mapper.Map<List<Product>>(productList);
        }

        public async Task<Product> Get(int id)
        {
            var product = await _ctx.Products.AsNoTracking()
                                    .Include(e => e.Category)
                                    .FirstOrDefaultAsync(c => c.ProductId == id);
            return _mapper.Map<Product>(product);
        }

        public async Task Add(Product product)
        {
            var productToAdd = _mapper.Map<Entities.Products>(product);
            await _ctx.AddAsync(productToAdd);
        }

        public void Update(Product product)
        {
            Entities.Products productUpdated = _mapper.Map<Entities.Products>(product);
            _ctx.Products.Attach(productUpdated);
            _ctx.Entry(productUpdated).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            var productToDelete = await _ctx.Products.FindAsync(id);
            _ctx.Products.Remove(productToDelete);
        }

        public async Task SaveChanges()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
