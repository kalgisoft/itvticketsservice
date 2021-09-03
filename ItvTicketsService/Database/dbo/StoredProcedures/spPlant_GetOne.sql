CREATE PROCEDURE [dbo].[spPlant_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany FROM Plant WHERE Id= @Id
END