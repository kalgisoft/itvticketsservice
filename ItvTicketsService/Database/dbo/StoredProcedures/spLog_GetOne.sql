CREATE PROCEDURE [dbo].[spLog_GetOne]
-- Needs one parameter for primary key
@LogId int
AS 
BEGIN
-- SQL Select for one table row
SELECT LogId, LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId FROM LogTable WHERE LogId = @LogId
END
