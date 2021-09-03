--------------  Stored Proc for DELETE
CREATE PROCEDURE spCompany_Delete
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Company WHERE Id = @Id
END
