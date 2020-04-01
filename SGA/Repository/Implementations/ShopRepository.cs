using Microsoft.Extensions.Configuration;
using Model;
using Repository.Helpers;
using Repository.Helpers.Implementations;
using Repository.Helpers.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class ShopRepository : IShopRepository
    {
        private readonly IDBhelper db;
        private IConfiguration configuration;
        private DataTable dt = new DataTable();
        private bool isCreated = false;
        private bool isDeleted = false;
        private bool isUpdated = false;
        public ShopRepository(IDBhelper _db,IConfiguration config)
        {
            db = _db;
            configuration = config;
        }
        
        public bool AddShop(Shop shop)
        {
            try
            {
                SqlParameter[] dbParameter =
                {
                    new SqlParameter("@shopname",shop.shopname),
                    new SqlParameter("@ownername",shop.ownername),
                    new SqlParameter("@longitude",shop.longitude),
                    new SqlParameter("@latitude",shop.latitude),
                    new SqlParameter("@imagepath",shop.imagepath)
                };
                isCreated = db.ExecuteNonQuery(SpConstants.SP_ADD_NEW_SHOP, dbParameter);
                return isCreated;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteShop(int id)
        {
            try
            {

                SqlParameter[] dbParameter = { new SqlParameter("@id", id) };
                isDeleted = db.ExecuteNonQuery(SpConstants.SP_DELETE_SHOP, dbParameter);
                return isDeleted;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<string> GetAllShops(int page)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] sqlParameter = { new SqlParameter("@page",page) };
                dt =await db.Get(SpConstants.SP_GET_ALL_SHOPS, sqlParameter);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                return "Exception occurs while fetching data from db";
            }
        }

        public string GetShopById(int id)
        {
            try
            {
                SqlParameter[] sqlParameter = { new SqlParameter("@ShopId", id) };
                return db.GetBy(SpConstants.SP_GET_SHOP_BY_ID, sqlParameter);
            }
            catch (Exception ex)
            {
                return "Exception occurs while fetching data from db";
            }

        }

        public string GetShopsByBrand(string brand)
        {
            try
            {
                SqlParameter[] sqlParameter = { new SqlParameter("@brand", brand) };
                return db.GetBy(SpConstants.SP_GET_SHOPS_BY_BRAND, sqlParameter);

            }
            catch (Exception ex)
            {
                return "Exception occurs while fetching data from db";
            }

        }

        public bool UpdateShop(Shop shop)
        {
            try
            {

                SqlParameter[] dbParameter = 
                {
                    new SqlParameter("@ShopId", shop.shopid),
                    new SqlParameter("@shopname",shop.shopname),
                    new SqlParameter("@ownername",shop.ownername),
                    new SqlParameter("@longitude",shop.longitude),
                    new SqlParameter("@latitude",shop.latitude),
                    new SqlParameter("@imagepath",shop.imagepath)
                };
                isUpdated = db.ExecuteNonQuery(SpConstants.SP_UPDATE_SHOP, dbParameter);
                return isUpdated;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
