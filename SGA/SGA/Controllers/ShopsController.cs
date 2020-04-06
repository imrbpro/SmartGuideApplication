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

        /// <summary>
        /// Get All Shops
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll/{page}")]
        public async Task<string> GetAllShops(int page)
        {
            return await _shopService.GetAllShops(page);
        }

        /// <summary>
        /// Get Specific Shop by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById/{id}")]
        public string GetShopById(int id)
        {
            return _shopService.GetShopById(id);
        }

        /// <summary>
        /// Get Shops by brand name
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetByBrand/{brand}")]
        public string GetShopByBrand(string brand)
        {
            return _shopService.GetShopsByBrand(brand);
        }

        /// <summary>
        /// Get Shop by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            return _shopService.DeleteShop(id);
        }

        /// <summary>
        /// Creates a new shop 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddNew")]
        public bool CreateShop([FromBody] Shop shop)
        {
            return _shopService.AddShop(shop);
        }

        /// <summary>
        /// Update specific shop by id
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public bool UpdateShop([FromBody] Shop shop)
        {
            return _shopService.UpdateShop(shop);
        }
    }
}
