using Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impementations
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;
        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public async Task<string> GetAllShops(int page)
        {
            return await _shopRepository.GetAllShops(page);
        }
        public string GetShopById(int id)
        {
            return _shopRepository.GetShopById(id);
        }
        public string GetShopsByBrand(string brand)
        {
            return _shopRepository.GetShopsByBrand(brand);
        }
        public bool DeleteShop(int id)
        {
            return _shopRepository.DeleteShop(id);
        }

        public bool AddShop(Shop shop)
        {
            return _shopRepository.AddShop(shop);
        }

        public bool UpdateShop(Shop shop)
        {
            return _shopRepository.UpdateShop(shop);
        }
    }
}
