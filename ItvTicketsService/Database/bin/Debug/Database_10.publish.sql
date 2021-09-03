/*
Script di distribuzione per ItvTicketsDB

Questo codice è stato generato da uno strumento.
Le modifiche apportate al file possono causare un comportamento non corretto e verranno perse se
il codice viene rigenerato.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ItvTicketsDB"
:setvar DefaultFilePrefix "ItvTicketsDB"
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
PRINT N'Eliminazione di Chiave esterna [dbo].[FK_Devices_Plant]...';


GO
ALTER TABLE [dbo].[Devices] DROP CONSTRAINT [FK_Devices_Plant];


GO
PRINT N'Eliminazione di Chiave esterna [dbo].[FK_Plant_Company]...';


GO
ALTER TABLE [dbo].[Plant] DROP CONSTRAINT [FK_Plant_Company];


GO
PRINT N'Avvio ricompilazione tabella [dbo].[Plant]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Plant] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [StreetAddress] NVARCHAR (50) NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         NVARCHAR (50) NULL,
    [ZipCode]       NVARCHAR (50) NULL,
    [Email]         NVARCHAR (50) NULL,
    [Phone]         NVARCHAR (50) NULL,
    [IdCompany]     INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Plant])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Plant] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Plant] ([Id], [Name], [StreetAddress], [City], [State], [ZipCode], [Email], [Phone], [IdCompany])
        SELECT   [Id],
                 [Name],
                 [StreetAddress],
                 [City],
                 [State],
                 [ZipCode],
                 [Email],
                 [Phone],
                 [IdCompany]
        FROM     [dbo].[Plant]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Plant] OFF;
    END

DROP TABLE [dbo].[Plant];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Plant]', N'Plant';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Devices_Plant]...';


GO
ALTER TABLE [dbo].[Devices] WITH NOCHECK
    ADD CONSTRAINT [FK_Devices_Plant] FOREIGN KEY ([PlantId]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Plant_Company]...';


GO
ALTER TABLE [dbo].[Plant] WITH NOCHECK
    ADD CONSTRAINT [FK_Plant_Company] FOREIGN KEY ([IdCompany]) REFERENCES [dbo].[Company] ([Id]);


GO
PRINT N'Aggiornamento di Routine [dbo].[spPlant_Delete]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPlant_Delete]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spPlant_GetOne]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPlant_GetOne]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spPlant_Insert]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPlant_Insert]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spPlant_List]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPlant_List]';


GO
PRINT N'Aggiornamento di Routine [dbo].[spPlant_Update]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spPlant_Update]';


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Devices] WITH CHECK CHECK CONSTRAINT [FK_Devices_Plant];

ALTER TABLE [dbo].[Plant] WITH CHECK CHECK CONSTRAINT [FK_Plant_Company];


GO
PRINT N'Aggiornamento completato.';


GO
