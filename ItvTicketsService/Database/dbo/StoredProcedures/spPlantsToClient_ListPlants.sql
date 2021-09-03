CREATE PROCEDURE [dbo].[spPlantsToClient_ListPlants]
@client int
AS
BEGIN
--SQL for Select stored procedure.
SELECT IdPlant FROM PlantsToClient WHERE IdClient = @client
END
