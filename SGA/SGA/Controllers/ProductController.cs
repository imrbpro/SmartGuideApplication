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
    public class ProductController : ControllerBase
    {
        private IProductService _svc;
        public ProductController(IProductService service)
        {
            _svc = service;
        }

        [HttpGet]
        [Route("GetAll/{page}")]
        public string GetAllProducts(int page)
        {
            return _svc.GetAll(page);
        }

        [HttpGet]
        [Route("GetByBrand/{id}")]
        public string GetProductsByBrandId(int id)
        {
            return _svc.GetByBrandId(id);
        }

        [HttpGet]
        [Route("GetBy/{id}")]
        public string GetProductsById(int id)
        {
            return _svc.GetById(id);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public string GetProductsByName(string name)
        {
            return _svc.GetByName(name);
        }

        [HttpGet]
        [Route("GetByShop/{id}")]
        public string GetProductsByShopId(int id)
        {
            return _svc.GetByShopId(id);
        }

        [HttpPost]
        [Route("Add")]
        public string AddNewProduct(Product product)
        {
            if (_svc.Add(product))
            {
                return StatusCodes.Status201Created.ToString();
            }
            else
            {
                return StatusCodes.Status400BadRequest.ToString();
            }
        }

        [HttpPut]
        [Route("Update")]
        public string UpdateProduct([FromBody] Product product)
        {
            if (_svc.Update(product))
            {
                return StatusCodes.Status200OK.ToString();
            }
            else
            {
                return StatusCodes.Status304NotModified.ToString();
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public string DeleteProduct(int id)
        {
            if (_svc.Delete(id))
            {
                return StatusCodes.Status200OK.ToString();
            }
            else
            {
                return StatusCodes.Status400BadRequest.ToString();
            }
        }
    }
}