﻿CREATE PROCEDURE [dbo].[SpUpdatePromotion]   @PromotionId int,   @PromotionName nvarchar(50),   @PromotionDetails nvarchar(350),   @BrandId int,   @ShopId int,   @StartDate datetime,   @EndDate datetime,   @Promocode nvarchar(50),   @isShop bit,   @isBrand bit  AS  BEGIN   UPDATE   Promotion   SET         promotion_name = @PromotionName,   promotion_details = @PromotionDetails,   brand_id = @BrandId,   shop_id = @ShopId,   startdate = @StartDate,   endtdate = @EndDate,   Promo_code = @Promocode,   isShop = @isShop,   isBrand = @isBrand      WHERE promotion_id = @PromotionId    END