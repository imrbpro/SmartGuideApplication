using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IShopService
    {
        Task<string> GetAllShops(int shop);  
    }
}
