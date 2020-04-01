using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IShopService
    {
        Task<string> GetAllShops(int shop);
        string GetShopById(int id);
        string GetShopsByBrand(string brand);
        bool DeleteShop(int id);
        bool AddShop(Shop shop);
        bool UpdateShop(Shop shop);

    }
}
