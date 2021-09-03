CREATE PROCEDURE [dbo].[spLog_Insert]
@LogLevel text,
@EventName text,
@Source text,
@ExceptionMessage text,
@StackTrace text,
@CreatedDate text,
@UserId INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO LogTable(LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId) VALUES (@LogLevel, @EventName, @Source, @ExceptionMessage, @StackTrace, @CreatedDate, @UserId)
RETURN SCOPE_IDENTITY()
END
