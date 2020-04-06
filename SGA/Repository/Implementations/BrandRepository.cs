using Model;
using Repository.Helpers;
using Repository.Helpers.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IDBhelper _db;
        public BrandRepository(IDBhelper dBhelper)
        {
            _db = dBhelper;
        }
        public bool Add(Brand brand)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Name",brand.Id),
                    new SqlParameter("@ShopNumber", brand.ShopNumbers),
                    new SqlParameter("@Owner", brand.ownername),
                    new SqlParameter("@ImagePath", brand.logopath)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_ADD_BRAND, parameters);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id",id)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_DELETE_BRAND, parameters);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GetAllBrand(int page)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@Page",page)
                };
                return _db.GetBy(SpConstants.SP_GET_ALL_BRANDS, parameter);
            }
            catch (Exception ex)
            {
                return "Error occured while getting data from DB";
            }
        }

        public string GetBrandById(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@BrandId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_BRAND_BY_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error occured while getting data from DB";
            }
        }

        public bool Update(Brand brand)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@Id",brand.Id),
                    new SqlParameter("@Name",brand.Name),
                    new SqlParameter("@ShopNumber",brand.ShopNumbers),
                    new SqlParameter("@Owner",brand.ownername),
                    new SqlParameter("@ImagePath",brand.logopath)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_UPDATE_BRAND, parameter);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
