CREATE PROCEDURE [dbo].[spPlant_Update]
-- Parameters for Update stored procedure.
@iD int,
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@IdCompany INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Plant SET Name = @Name, StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode, Email = @Email, Phone = @Phone, IdCompany = @IdCompany WHERE Id = @Id
END
