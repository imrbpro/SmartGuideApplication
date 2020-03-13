using Model.Entities;
using Services.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IShopService:IGenericService<Shop>
    {
        List<Shop> GetAllShops();
        
    }
}
