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
    public class BrandController : ControllerBase
    {

        IBrandService _svc;
        public BrandController(IBrandService service)
        {
            _svc = service;
        }

        ///<summary> 
        ///Get all Brands 
        ///</summary>
        ///<param name="page"><param>
        ///<returns></returns>
        [HttpGet]
        [Route("GetAll/{page}")]
        public string GetAllBrands(int page)
        {
            return _svc.GetAllBrands(page);
        }

        ///<summary> 
        ///Get Brand by id
        ///</summary>
        ///<param name="id"><param>
        ///<returns></returns>
        [HttpGet]
        [Route("GetById/{id}")]
        public string GetBrandById(int id)
        {
            return _svc.GetBrandById(id);
        }

        ///<summary> 
        ///Adds new brand
        ///</summary>
        ///<returns></returns>
        [HttpPost]
        [Route("AddNew")]
        public string AddBrand([FromBody] Brand brand)
        {
            if (_svc.Add(brand))
            {
                return StatusCodes.Status201Created.ToString();
            }
            else
            {
                return StatusCodes.Status400BadRequest.ToString();
            }
        }

        ///<summary> 
        ///Update Current brand
        ///</summary>
        ///<returns></returns>
        [HttpPost]
        [Route("Update")]
        public string UpdateBrand([FromBody] Brand brand)
        {
            if (_svc.Update(brand))
            {
                return StatusCodes.Status200OK.ToString();
            }
            else
            {
                return StatusCodes.Status400BadRequest.ToString();
            }
        }

        ///<summary> 
        ///Delete existing brand 
        ///</summary>
        ///<param name="id"><param>
        ///<returns></returns>
        [HttpDelete]
        [Route("Delete")]
        public string DeleteBrand(int id)
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
