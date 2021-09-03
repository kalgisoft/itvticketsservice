CREATE PROCEDURE [dbo].[spDevice_Insert]
--Parameters for Insert stored procedure
@Code NVARCHAR(10),
@Type NVARCHAR(50),
@Info NVARCHAR(50),
@PlantId INT,
@NumLinea INT,
@IdContractor INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Devices(Code, Type, Info, PlantId, NumLinea, IdContractor) VALUES (@Code, @Type, @Info, @PlantId, @NumLinea, @IdContractor)
RETURN SCOPE_IDENTITY()
END
