using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services.Interfaces;

namespace SGA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IShopService _shopService;
        public ShopsController(IShopService ShopService)
        {
            _shopService = ShopService;
        }
        [HttpGet]
        [Route("GetAll/{page}")]
        public async Task<string> GetAllShops(int page)
        {
            return await _shopService.GetAllShops(page);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public string GetShopById(int id)
        {
            return _shopService.GetShopById(id);
        }

        [HttpGet]
        [Route("GetByBrand/{brand}")]
        public string GetShopByBrand(string brand)
        {
            return _shopService.GetShopsByBrand(brand);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            return _shopService.DeleteShop(id);
        }
        [HttpPost]
        [Route("AddNew")]
        public bool CreateShop([FromBody] Shop shop)
        {
            return _shopService.AddShop(shop);
        }
        [HttpPut]
        [Route("Update")]
        public bool UpdateShop([FromBody] Shop shop)
        {
            return _shopService.UpdateShop(shop);
        }
    }
}
