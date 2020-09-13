using Stocker.Application.Interfaces;
using Stocker.Application.Repositories;
using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Application.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public Task<List<Product>> Get(bool excludehighstock)
        {
            return _productRepository.Get(excludehighstock);
        }

        public Task<Product> Get(int id)
        {
            return _productRepository.Get(id);
        }

        public async Task Add(Product product)
        {
            await _productRepository.Add(product);
            await _productRepository.SaveChanges();
        }

        public async Task Update(Product product)
        {
            _productRepository.Update(product);
            await _productRepository.SaveChanges();
        }

        public async Task UpdateAll(List<Product> products)
        {
            foreach (Product newProduct in products)
            {
                Product product = await _productRepository.Get(newProduct.Id);
                product.Stock = newProduct.Stock;
                _productRepository.Update(product);
            }

            await _productRepository.SaveChanges();
        }

        public async Task Delete(int id)
        {
            await _productRepository.Delete(id);
            await _productRepository.SaveChanges();
        }
    }
}
