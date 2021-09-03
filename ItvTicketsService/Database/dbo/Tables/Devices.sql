CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NCHAR(10) NOT NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Info] NVARCHAR(50) NULL, 
    [PlantId] INT NULL, 
    [NumLinea] INT NULL, 
    [IdContractor] INT NULL, 
    CONSTRAINT [FK_Devices_Plant] FOREIGN KEY ([PlantId]) REFERENCES [Plant]([Id]), 
    CONSTRAINT [FK_Devices_Contractors] FOREIGN KEY ([IdContractor]) REFERENCES [Contractors]([Id])
)
