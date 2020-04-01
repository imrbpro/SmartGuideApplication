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
    }
}
