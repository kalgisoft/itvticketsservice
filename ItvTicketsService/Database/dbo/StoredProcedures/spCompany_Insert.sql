CREATE PROCEDURE spCompany_Insert
--Parameters for Insert stored procedure
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@TicketAmount INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Company(Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount) VALUES (@Name, @StreetAddress, @City, @State, @ZipCode, @Email, @Phone, @TicketAmount)
RETURN SCOPE_IDENTITY()
END
