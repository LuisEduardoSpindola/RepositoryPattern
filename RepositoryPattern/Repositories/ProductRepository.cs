using MicroSource.Api.Models;
using RepositoryPattern.Data;
using RepositoryPattern.Interface;
using System;
using System.Linq;

namespace RepositoryPattern.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AplicationContext _context;

        public ProductRepository(AplicationContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception("Produto não encontrado");
            }
            return product;
        }

        public Product Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
