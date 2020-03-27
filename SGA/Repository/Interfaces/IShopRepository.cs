using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IShopRepository
    {
        Task<string> GetAllShops(int page);
        string GetShopById(int id);
        string GetShopsByBrand(string brand);
        bool AddShop(Shop shop);
        bool UpdateShop(int id, Shop shop);
        bool DeleteShop(int id);

    }
}
