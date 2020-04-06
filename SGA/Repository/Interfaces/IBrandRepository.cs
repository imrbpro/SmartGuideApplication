using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBrandRepository
    {
        bool Add(Brand brand);
        bool Update(Brand brand);
        bool Delete(int id);
        string GetAllBrand(int page);
        string GetBrandById(int id);
    }
}
