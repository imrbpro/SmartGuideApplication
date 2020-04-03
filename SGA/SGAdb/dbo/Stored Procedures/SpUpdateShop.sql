CREATE PROCEDURE SpUpdateShop
	@ShopId int,
	@shopname nvarchar(50),
	@ownername nvarchar(50),
	@longitude nvarchar(50),
	@latitude nvarchar(50),
	@imagepath nvarchar(max)
AS
BEGIN
	UPDATE 
	shop 
	SET 
	shop_name = @shopname,
	shop_owner = @ownername,
	shop_longitude = @longitude,
	shop_latitude = @latitude,
	shop_image = @imagepath
	Where shop_id = @ShopId 
END
