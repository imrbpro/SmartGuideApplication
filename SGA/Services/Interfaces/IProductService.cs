using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IProductService
    {
        string GetAll(int page);
        string GetById(int id);
        string GetByName(string name);
        string GetByShopId(int id);
        string GetByBrandId(int id);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int id);

    }
}
