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
    public class PromotionController : ControllerBase
    {
        private IPromotionService _svc;
        public PromotionController(IPromotionService service)
        {
            _svc = service;
        }

        [HttpGet]
        [Route("GetAll/{id}")]
        public string GetAllPromotions(int page)
        {
            return _svc.GetAll(page);
        }

        [HttpGet]
        [Route("GetBy/{id}")]
        public string GetPromotionById(int id)
        {
            return _svc.GetById(id);
        }

        [HttpGet]
        [Route("GetByBrand/{id}")]
        public string GetPromotionsByBrand(int id)
        {
            return _svc.GetByBrand(id);
        }

        [HttpGet]
        [Route("GetByShop/{id}")]
        public string GetPromotionsByShop(int id)
        {
            return _svc.GetByShop(id);
        }

        [HttpPost]
        [Route("Add")]
        public string AddPromotion([FromBody] Promotion promo)
        {
            if (_svc.Add(promo))
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
        public string Update([FromBody] Promotion promo)
        {
            if (_svc.Update(promo))
            {
                return StatusCodes.Status200OK.ToString();
            }
            else
            {
                return StatusCodes.Status400BadRequest.ToString();
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public string Delete(int id)
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