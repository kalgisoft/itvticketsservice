CREATE PROCEDURE [dbo].[spLog_Delete]
@LogId int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM LogTable WHERE LogId = @LogId
END
