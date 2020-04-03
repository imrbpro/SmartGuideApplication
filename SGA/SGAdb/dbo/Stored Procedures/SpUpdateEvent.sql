CREATE PROCEDURE [dbo].[SpUpdateEvent]
	@EventId int,
	@ShopId int,
	@BrandId int,
	@EventName nvarchar(50),
	@EventDetails nvarchar(50),
	@EventDateTime date
AS
BEGIN
	UPDATE
	Event
	SET 
	shop_id = @ShopId,
	brand_id = @BrandId,
	event_name = @EventName,
	event_details = @EventDetails,
	event_datetime = @EventDateTime
	Where event_id = @EventId
END
