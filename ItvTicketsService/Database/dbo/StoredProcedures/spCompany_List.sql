--------------  Stored Proc for SELECT
CREATE PROCEDURE spCompany_List
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount FROM Company ORDER BY Id DESC
END
