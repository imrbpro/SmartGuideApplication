using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IBrandService
    {
        string GetAllBrands(int page);
        string GetBrandById(int id);
        bool Add(Brand brand);
        bool Update(Brand brand);
        bool Delete(int id);
    }
}
