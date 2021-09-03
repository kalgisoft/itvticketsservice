/*
Script di distribuzione per ItvTicketsDBNew

Questo codice è stato generato da uno strumento.
Le modifiche apportate al file possono causare un comportamento non corretto e verranno perse se
il codice viene rigenerato.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ItvTicketsDBNew"
:setvar DefaultFilePrefix "ItvTicketsDBNew"
:setvar DefaultDataPath "C:\Users\user\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\user\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Rileva la modalità SQLCMD e disabilita l'esecuzione dello script se la modalità SQLCMD non è supportata.
Per abilitare nuovamente lo script dopo aver abilitato la modalità SQLCMD, eseguire l'istruzione seguente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Per la corretta esecuzione dello script è necessario abilitare la modalità SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367)) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Modifica di Tabella [dbo].[Devices]...';


GO
ALTER TABLE [dbo].[Devices]
    ADD [IdContractor] INT NULL;


GO
PRINT N'Creazione di Tabella [dbo].[Contractors]...';


GO
CREATE TABLE [dbo].[Contractors] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[PlantsToClient]...';


GO
CREATE TABLE [dbo].[PlantsToClient] (
    [IdClient] INT NOT NULL,
    [IdPlant]  INT NOT NULL
);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_PlantsToClient_ToApplicationUser]...';


GO
ALTER TABLE [dbo].[PlantsToClient] WITH NOCHECK
    ADD CONSTRAINT [FK_PlantsToClient_ToApplicationUser] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_PlantsToClient_ToPlant]...';


GO
ALTER TABLE [dbo].[PlantsToClient] WITH NOCHECK
    ADD CONSTRAINT [FK_PlantsToClient_ToPlant] FOREIGN KEY ([IdPlant]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Devices_Contractors]...';


GO
ALTER TABLE [dbo].[Devices] WITH NOCHECK
    ADD CONSTRAINT [FK_Devices_Contractors] FOREIGN KEY ([IdContractor]) REFERENCES [dbo].[Contractors] ([Id]);


GO
PRINT N'Creazione di Routine [dbo].[spContractors_Delete]...';


GO
CREATE PROCEDURE [dbo].[spContractors_Delete]
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Contractors WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spContractors_GetOne]...';


GO
CREATE PROCEDURE [dbo].[spContractors_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name FROM Contractors WHERE Id= @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spContractors_Insert]...';


GO
CREATE PROCEDURE [dbo].[spContractors_Insert]
--Parameters for Insert stored procedure
@Name NVARCHAR(50)
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Contractors(Name) VALUES (@name)
RETURN SCOPE_IDENTITY()
END
GO
PRINT N'Creazione di Routine [dbo].[spContractors_List]...';


GO
CREATE PROCEDURE [dbo].[spContractors_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name FROM Contractors ORDER BY Id DESC
END
GO
PRINT N'Creazione di Routine [dbo].[spContractors_Update]...';


GO
CREATE PROCEDURE [dbo].[spContractors_Update]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0
GO
PRINT N'Creazione di Routine [dbo].[spPlantsToClient_Upsert]...';


GO
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
GO
PRINT N'Aggiornamento di Routine [dbo].[spDevice_Delete]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDevice_Delete]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spDevice_GetOne]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDevice_GetOne]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spDevice_Insert]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDevice_Insert]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spDevice_List]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDevice_List]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spDevice_Update]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spDevice_Update]';


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[PlantsToClient] WITH CHECK CHECK CONSTRAINT [FK_PlantsToClient_ToApplicationUser];

ALTER TABLE [dbo].[PlantsToClient] WITH CHECK CHECK CONSTRAINT [FK_PlantsToClient_ToPlant];

ALTER TABLE [dbo].[Devices] WITH CHECK CHECK CONSTRAINT [FK_Devices_Contractors];


GO
PRINT N'Aggiornamento completato.';


GO
