using Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Impementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repo;
        public BrandService(IBrandRepository brandRepository)
        {
            _repo = brandRepository;
        }
        public bool Add(Brand brand)
        {
            return _repo.Add(brand);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public string GetAllBrands(int page)
        {
            return _repo.GetAllBrand(page);
        }

        public string GetBrandById(int id)
        {
            return _repo.GetBrandById(id);
        }

        public bool Update(Brand brand)
        {
            return _repo.Update(brand);
        }
    }
}
