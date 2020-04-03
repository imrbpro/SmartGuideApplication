CREATE PROCEDURE [dbo].[SpGetEventById]
	@EventId int
AS
BEGIN
	SELECT * FROM 
	Event WHERE shop_id = @EventId
	FOR JSON PATH 
END
