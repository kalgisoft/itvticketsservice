CREATE PROCEDURE [dbo].[spPlant_Insert]
--Parameters for Insert stored procedure
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
--SQL for Insert stored procedure
INSERT INTO Plant(Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany) VALUES (@name, @StreetAddress, @City, @State, @ZipCode, @Email, @Phone, @IdCompany)
RETURN SCOPE_IDENTITY()
END
