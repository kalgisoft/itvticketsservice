--------------  Stored Proc for UPDATE
CREATE PROCEDURE spCompany_Update
-- Parameters for Update stored procedure.
@iD int,
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
-- SQL for Update stored procedure
UPDATE Company SET Name = @Name, StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode, Email = @Email, Phone = @Phone, TicketAmount = @TicketAmount WHERE Id = @Id
END
