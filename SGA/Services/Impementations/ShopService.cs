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
        IShopRepository _shopRepository;
        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public async Task<string> GetAllShops(int page)
        {
            return await _shopRepository.GetAllShops(page);
        }
    }
}
