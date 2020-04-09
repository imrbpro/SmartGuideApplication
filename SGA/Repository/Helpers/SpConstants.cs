namespace Repository.Helpers
{
    public class SpConstants
    {
        #region Shop
        public const string SP_ADD_NEW_SHOP = "SpAddNewShop";
        public const string SP_DELETE_SHOP = "SpDeleteShop";
        public const string SP_UPDATE_SHOP = "SpUpdateShop";
        public const string SP_GET_ALL_SHOPS = "SpGetAllShops";
        public const string SP_GET_SHOP_BY_ID = "SpGetShopById";
        public const string SP_GET_SHOPS_BY_BRAND = "SpGetShopByBrand";
        #endregion
        #region Event
        public const string SP_ADD_EVENT = "SpAddEvent";
        public const string SP_GET_EVENT_BY_ID = "SpGetEventById";
        public const string SP_GET_EVENT_BY_SHOP = "SpGetEventByShop";
        public const string SP_GET_EVENT_BY_BRAND = "SpGetEventByBrand";
        public const string SP_UPDATE_EVENT = "SpUpdateEvent";
        public const string SP_DELETE_EVENT_BY_ID = "SpDeleteEvent";
        public const string SP_GET_ALL_EVENTS = "SpGetAllEvents";
        #endregion
        #region Brand
        public const string SP_GET_BRAND_BY_ID = "SpGetBrandById";
        public const string SP_GET_ALL_BRANDS = "SpGetAllBrands";
        public const string SP_DELETE_BRAND = "SpDeleteBrand";
        public const string SP_UPDATE_BRAND = "SpUpdateBrand";
        public const string SP_ADD_BRAND = "SpAddBrand";
        #endregion
        #region Product
        public const string SP_ADD_NEW_PRODUCT = "SpAddProduct";
        public const string SP_UPDATE_PRODUCT = "SpUpdateProduct";
        public const string SP_DELETE_PRODUCT = "SpDeleteProduct";
        public const string SP_GET_ALL_PRODUCTS = "SpGetAllProducts";
        public const string SP_GET_PRODUCT_BY_ID = "SpGetProductById";
        public const string SP_GET_PRODUCT_BY_BRAND_ID = "SpGetProductsByBrandId";
        public const string SP_GET_PRODUCT_BY_SHOP_ID = "SpGetProductByShopId";
        public const string SP_GET_PRODUCT_BY_NAME = "SpGetProductByName";
        #endregion
        #region Promotion
        public const string SP_ADD_PROMOTION = "SpAddPromotion";
        public const string SP_UPDATE_PROMOTION = "SpUpdatePromotion";
        public const string SP_DELETE_PROMOTION = "SpDeletePromotion";
        public const string SP_GET_ALL_PROMOTIONS = "SpGetAllPromotions";
        public const string SP_GET_PROMOTION_BY_ID = "SpGetPromotionById";
        public const string SP_GET_PROMOTION_BY_BRAND_ID = "SpGetPromotionByBrandId";
        public const string SP_GET_PROMOTION_BY_SHOP_ID = "SpGetPromotionByShopId";
        #endregion
    }
}
