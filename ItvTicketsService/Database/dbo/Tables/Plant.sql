CREATE TABLE [dbo].[Plant]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [StreetAddress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NULL, 
    [ZipCode] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [IdCompany] INT NULL, 
    CONSTRAINT [FK_Plant_Company] FOREIGN KEY ([IdCompany]) REFERENCES [Company]([Id])
)
