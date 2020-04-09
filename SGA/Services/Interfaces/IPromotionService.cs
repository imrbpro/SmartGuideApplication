using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IPromotionService
    {
        string GetAll(int page);
        string GetById(int id);
        string GetByBrand(int id);
        string GetByShop(int id);
        bool Add(Promotion promo);
        bool Update(Promotion promo);
        bool Delete(int id);
    }
}
