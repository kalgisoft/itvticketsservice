CREATE PROCEDURE [dbo].[spDevice_Update]
-- Parameters for Update stored procedure.
@iD int,
@Code NVARCHAR(10),
@Type NVARCHAR(50),
@Info NVARCHAR(50),
@PlantId INT,
@NumLinea INT,
@IdContractor INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Devices SET Code = @Code, Type = @Type, Info = @Info, PlantId = @PlantId, NumLinea = @NumLinea, IdContractor = @IdContractor WHERE Id = @Id
END
