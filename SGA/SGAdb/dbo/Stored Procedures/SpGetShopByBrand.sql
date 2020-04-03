CREATE PROCEDURE SpGetShopByBrand
	@brand nvarchar(50)
AS
BEGIN
	SELECT * FROM 
	shop WHERE shop_name = @brand
	FOR JSON PATH 
END
