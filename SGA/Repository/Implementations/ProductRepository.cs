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
    public class ProductRepository : IProductRepository
    {
        IDBhelper _db;
        public ProductRepository(IDBhelper dBhelper)
        {
            _db = dBhelper;
        }
        public bool Add(Product product)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ShopId",product.ShopId),
                    new SqlParameter("@BrandId",product.BrandId),
                    new SqlParameter("@ProductName",product.ProductName),
                    new SqlParameter("@ProductColor",product.ProductColor),
                    new SqlParameter("@ImagePath",product.ProductImage)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_ADD_NEW_PRODUCT,parameter);
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
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ProductId",id)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_DELETE_PRODUCT, parameter);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GetAll(int page)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@Page",page)
                };
                return _db.GetBy(SpConstants.SP_GET_ALL_PRODUCTS, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting Data from Database";
            }
        }

        public string GetByBrandId(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@BrandId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PRODUCT_BY_BRAND_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting Data from Database";
            }
        }

        public string GetById(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ProductId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PRODUCT_BY_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting Data from Database";
            }
        }

        public string GetByName(string name)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@Name",name)
                };
                return _db.GetBy(SpConstants.SP_GET_PRODUCT_BY_NAME, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting Data from Database";
            }
        }

        public string GetByShopId(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ShopId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PRODUCT_BY_SHOP_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting Data from Database";
            }
        }

        public bool Update(Product product)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ProductId",product.Id),
                    new SqlParameter("@ShopId",product.ShopId),
                    new SqlParameter("@BrandId",product.BrandId),
                    new SqlParameter("@ProductName",product.ProductName),
                    new SqlParameter("@ProductColor",product.ProductColor),
                    new SqlParameter("@ImagePath",product.ProductImage)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_UPDATE_PRODUCT, parameter);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
