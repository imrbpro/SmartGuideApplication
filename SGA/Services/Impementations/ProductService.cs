using Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Impementations
{
    public class ProductService : IProductService
    {
        IProductRepository _repo;
        public ProductService(IProductRepository repository)
        {
            _repo = repository;
        }
        public bool Add(Product product)
        {
            return _repo.Add(product);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public string GetAll(int page)
        {
            return _repo.GetAll(page);
        }

        public string GetByBrandId(int id)
        {
            return _repo.GetByBrandId(id);
        }

        public string GetById(int id)
        {
            return _repo.GetById(id);
        }

        public string GetByName(string name)
        {
            return _repo.GetByName(name);
        }

        public string GetByShopId(int id)
        {
            return _repo.GetByShopId(id);
        }

        public bool Update(Product product)
        {
            return _repo.Update(product);
        }
    }
}
