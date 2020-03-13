using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Repository.Helpers.Implementations;
using Repository.Interfaces;
using Services.Common.Implementation;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Impementations
{
    public class ShopService : GenericService<Shop>, IShopService
    {
        public readonly IShopRepository shopRepository;
        public ShopService(DbContext dbContext)
        {
            UnitOfWork = new UnitOfWork(dbContext);
        }
        public List<Shop> GetAllShops()
        {
            throw new NotImplementedException();
        }
    }
}
