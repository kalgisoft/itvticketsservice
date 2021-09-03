CREATE PROCEDURE [dbo].[spContractors_Delete]
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Contractors WHERE Id = @Id
END