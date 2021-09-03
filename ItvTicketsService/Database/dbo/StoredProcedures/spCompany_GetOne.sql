--------------  Stored Proc for SELECT (one)
CREATE PROCEDURE spCompany_GetOne
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount FROM Company WHERE Id= @Id
END
