using Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Impementations
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _repo;
        public PromotionService(IPromotionRepository repository)
        {
            _repo = repository;
        }
        public bool Add(Promotion promo)
        {
            return _repo.Add(promo);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public string GetAll(int page)
        {
            return _repo.GetAll(page);
        }

        public string GetByBrand(int id)
        {
            return _repo.GetByBrand(id);
        }

        public string GetById(int id)
        {
            return _repo.GetById(id);
        }

        public string GetByShop(int id)
        {
            return _repo.GetByShop(id);
        }

        public bool Update(Promotion promo)
        {
            return _repo.Update(promo);
        }
    }
}
