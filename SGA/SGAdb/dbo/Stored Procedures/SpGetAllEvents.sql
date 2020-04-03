﻿CREATE PROCEDURE [dbo].[SpGetAllEvents]
	@Page int
AS
BEGIN
	SELECT * FROM 
	Event 
	ORDER BY event_id 
	OFFSET (@Page - 1) * 10 ROWS 
	FETCH 
	NEXT 10 ROWS ONLY 
	FOR JSON PATH 
END
