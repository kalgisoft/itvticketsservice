CREATE PROCEDURE [dbo].[spPlantsToClient_Upsert]
@client int,
@plant int
AS
BEGIN  
    SET NOCOUNT ON;

-- Update the row if it exists.
    UPDATE PlantsToClient
	SET
	IdClient = @client,
	IdPlant = @plant
	WHERE IdClient = @client AND IdPlant = @plant

-- Insert the row if the UPDATE statement failed.  
	IF (@@ROWCOUNT = 0 )  
		BEGIN  
			INSERT INTO PlantsToClient (IdClient, IdPlant)
			VALUES (@client, @plant)
		END
	SET NOCOUNT OFF;
END
