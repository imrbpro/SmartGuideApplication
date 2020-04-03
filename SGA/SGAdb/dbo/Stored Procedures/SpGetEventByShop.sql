CREATE PROCEDURE [dbo].[SpGetEventByShop]
	@ShopId int
AS
BEGIN
	SELECT * FROM 
	Event WHERE shop_id = @ShopId
	FOR JSON PATH 
END
