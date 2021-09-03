CREATE PROCEDURE [dbo].[spContractors_Insert]
--Parameters for Insert stored procedure
@Name NVARCHAR(50)
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Contractors(Name) VALUES (@name)
RETURN SCOPE_IDENTITY()
END
