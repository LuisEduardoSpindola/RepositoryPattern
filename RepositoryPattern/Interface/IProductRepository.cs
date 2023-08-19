using System;
using System.Collections.Generic;
using MicroSource.Api.Models;

namespace RepositoryPattern.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Guid id);
    }
}
