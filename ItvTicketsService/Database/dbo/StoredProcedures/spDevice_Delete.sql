CREATE PROCEDURE [dbo].[spDevice_Delete]
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Devices WHERE Id = @Id
END
