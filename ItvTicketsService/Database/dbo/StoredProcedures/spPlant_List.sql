CREATE PROCEDURE [dbo].[spPlant_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany FROM Plant ORDER BY Id DESC
END
