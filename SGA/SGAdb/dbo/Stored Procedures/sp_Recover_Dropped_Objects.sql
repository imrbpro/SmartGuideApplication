﻿CREATE PROCEDURE [dbo].[sp_Recover_Dropped_Objects]
    @Database_Name NVARCHAR(MAX),
    @Date_From DATETIME,
    @Date_To DATETIME
AS

DECLARE @Compatibility_Level INT

SELECT @Compatibility_Level=dtb.compatibility_level
FROM master.sys.databases AS dtb WHERE dtb.name=@Database_Name

IF ISNULL(@Compatibility_Level,0)<=80
BEGIN
    RAISERROR('The compatibility level should be equal to or greater SQL SERVER 2005 (90)',16,1)
    RETURN
END

Select [Database Name],Convert(varchar(Max),Substring([RowLog Contents 0],33,LEN([RowLog Contents 0]))) as [Script]
from fn_dblog(NULL,NULL)
Where [Operation]='LOP_DELETE_ROWS' And [Context]='LCX_MARK_AS_GHOST'
And [AllocUnitName]='sys.sysobjvalues.clst'
AND [TRANSACTION ID] IN (SELECT DISTINCT [TRANSACTION ID] FROM    sys.fn_dblog(NULL, NULL)
WHERE Context IN ('LCX_NULL') AND Operation in ('LOP_BEGIN_XACT') 
And [Transaction Name]='DROPOBJ'
And  CONVERT(NVARCHAR(11),[Begin Time]) BETWEEN @Date_From AND @Date_To)
And Substring([RowLog Contents 0],33,LEN([RowLog Contents 0]))<>0