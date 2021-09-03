CREATE TABLE [dbo].[PlantsToClient]
(
	[IdClient] INT NOT NULL , 
    [IdPlant] INT NOT NULL, 
    CONSTRAINT [FK_PlantsToClient_ToApplicationUser] FOREIGN KEY ([IdClient]) REFERENCES [ApplicationUser]([Id]), 
    CONSTRAINT [FK_PlantsToClient_ToPlant] FOREIGN KEY ([IdPlant]) REFERENCES [Plant]([Id])
)
