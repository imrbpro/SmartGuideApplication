CREATE PROCEDURE [dbo].[SpGetEventByBrand]
	@BrandId int
AS
BEGIN
	SELECT * FROM 
	Event WHERE brand_id = @BrandId
	FOR JSON PATH 
END
