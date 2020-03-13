using System;
using System.Collections.Generic;
using Model.Entities;
using System.Text;

namespace Repository.Interfaces
{
    public interface IShopRepository
    {
        IEnumerable<Shop> GetAllShops();
        List<Shop> GetShopById(int id);
    }
}
