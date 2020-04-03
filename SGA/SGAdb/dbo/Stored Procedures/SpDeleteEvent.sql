CREATE PROCEDURE [dbo].[SpDeleteEvent]
	@EventId int
AS
BEGIN
DELETE Event where event_id = @EventId
END
