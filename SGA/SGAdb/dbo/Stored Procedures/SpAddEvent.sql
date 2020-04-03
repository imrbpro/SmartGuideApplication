CREATE PROCEDURE SpAddEvent
	@shopid int,
	@brandid int,
	@eventname nvarchar(50),
	@eventdetails nvarchar(50),
	@eventdate date
AS
BEGIN
	INSERT INTO 
	Event(
	shop_id,
	brand_id,
	event_name,
	event_details,
	event_datetime
	) 
	VALUES(
	@shopid,
	@brandid,
	@eventname,
	@eventdetails,
	@eventdate
	)

END
