﻿CREATE PROCEDURE SpGetShopById
	@ShopId int
AS
BEGIN
	SELECT * FROM 
	shop WHERE shop_id = @ShopId
	FOR JSON PATH 
END
