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
    public class PromotionRepository : IPromotionRepository
    {
        IDBhelper _db;
        Validate validate = new Validate();
        public PromotionRepository(IDBhelper dBhelper)
        {
            _db = dBhelper;
        }
        public bool Add(Promotion promo)
        {
            DateTime StartDate = validate.ValidateDateTime(promo.StartDate);
            DateTime EndDate = validate.ValidateDateTime(promo.EndDate);
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@PromotionName",promo.Name),
                    new SqlParameter("@PromotionDetails",promo.Details),
                    new SqlParameter("@BrandId",promo.BrandId),
                    new SqlParameter("@ShopId",promo.ShopId),
                    new SqlParameter("@StartDate",StartDate),
                    new SqlParameter("@EndDate",EndDate),
                    new SqlParameter("@Promocode",promo.PromoCode),
                    new SqlParameter("@isShop",promo.isShop),
                    new SqlParameter("@isBrand",promo.isBrand)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_ADD_PROMOTION, parameter);
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
                    new SqlParameter("@PromotionId",id)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_DELETE_PROMOTION, parameter);
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
                return _db.GetBy(SpConstants.SP_GET_ALL_PROMOTIONS, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting data from database";
            }
        }

        public string GetByBrand(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@BrandId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PROMOTION_BY_BRAND_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting data from database";
            }
        }

        public string GetById(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@PromotionId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PROMOTION_BY_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting data from database";
            }
        }

        public string GetByShop(int id)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ShopId",id)
                };
                return _db.GetBy(SpConstants.SP_GET_PROMOTION_BY_SHOP_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error Getting data from database";
            }
        }

        public bool Update(Promotion promo)
        {
            DateTime StartDate = validate.ValidateDateTime(promo.StartDate);
            DateTime EndDate = validate.ValidateDateTime(promo.EndDate);
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@PromotionId",promo.Id),
                    new SqlParameter("@PromotionName",promo.Name),
                    new SqlParameter("@PromotionDetails",promo.Details),
                    new SqlParameter("@BrandId",promo.BrandId),
                    new SqlParameter("@ShopId",promo.ShopId),
                    new SqlParameter("@StartDate",StartDate),
                    new SqlParameter("@EndDate",EndDate),
                    new SqlParameter("@Promocode",promo.PromoCode),
                    new SqlParameter("@isShop",promo.isShop),
                    new SqlParameter("@isBrand",promo.isBrand)
                };
                return _db.ExecuteNonQuery(SpConstants.SP_UPDATE_PROMOTION, parameter);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
