CREATE PROCEDURE [dbo].[spDevice_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Code, Type, Info, PlantId, NumLinea, IdContractor FROM Devices ORDER BY Id DESC
END
