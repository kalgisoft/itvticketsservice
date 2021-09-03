CREATE PROCEDURE [dbo].[spContractors_Update]
-- Parameters for Update stored procedure.
@Id int,
@Name NVARCHAR(50)
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Contractors SET Name = @Name WHERE Id = @Id
END
