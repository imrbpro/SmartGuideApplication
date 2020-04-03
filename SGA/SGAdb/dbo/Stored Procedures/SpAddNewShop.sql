
CREATE PROCEDURE SpAddNewShop 
	@shopname nvarchar(50),
	@ownername nvarchar(50),
	@longitude nvarchar(50),
	@latitude nvarchar(50),
	@imagepath nvarchar(max)
AS
BEGIN
	INSERT into shop(shop_name,shop_owner,shop_longitude,shop_latitude,shop_image)
	VALUES(@shopname,@ownername,@longitude,@latitude,@imagepath)
END
