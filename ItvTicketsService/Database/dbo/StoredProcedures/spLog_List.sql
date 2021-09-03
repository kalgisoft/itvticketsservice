CREATE PROCEDURE [dbo].[spLog_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT LogId, LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId FROM LogTable ORDER BY LogId DESC
END
