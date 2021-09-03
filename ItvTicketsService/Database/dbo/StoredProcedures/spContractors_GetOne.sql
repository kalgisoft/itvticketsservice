CREATE PROCEDURE [dbo].[spContractors_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name FROM Contractors WHERE Id= @Id
END
