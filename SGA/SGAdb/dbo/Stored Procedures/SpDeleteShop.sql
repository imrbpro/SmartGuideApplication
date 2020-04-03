CREATE PROCEDURE SpDeleteShop
	@id int
AS
BEGIN
	DELETE from shop where shop_id = @id
END
