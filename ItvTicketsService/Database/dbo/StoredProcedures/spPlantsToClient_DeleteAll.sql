CREATE PROCEDURE [dbo].[spPlantsToClient_DeleteAll]
@client int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM PlantsToClient WHERE IdClient = @client
END