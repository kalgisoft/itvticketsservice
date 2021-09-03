CREATE PROCEDURE [dbo].[spDevice_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Code, Type, Info, PlantId, NumLinea, IdContractor FROM Devices WHERE Id= @Id
END
