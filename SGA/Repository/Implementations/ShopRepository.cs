using Model.Entities;
using Repository.Helpers.Implementations;
using Repository.Helpers.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementations
{
    public class ShopRepository : GenericRepository<Shop>, IShopRepository
    {
        public ShopRepository(IUnitOfWork unit) : base(unit)
        {
        }

        public IEnumerable<Shop> GetAllShops()
        {
            return Get();
        }

        public List<Shop> GetShopById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
