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
PRINT N'Modifica di Tabella [dbo].[Devices]...';


GO
ALTER TABLE [dbo].[Devices] ALTER COLUMN [PlantId] INT NULL;


GO
PRINT N'Modifica di Tabella [dbo].[Tickets]...';


GO
ALTER TABLE [dbo].[Tickets] ALTER COLUMN [UserId] INT NULL;


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Devices_Plant]...';


GO
ALTER TABLE [dbo].[Devices] WITH NOCHECK
    ADD CONSTRAINT [FK_Devices_Plant] FOREIGN KEY ([PlantId]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Devices] WITH CHECK CHECK CONSTRAINT [FK_Devices_Plant];


GO
PRINT N'Aggiornamento completato.';


GO
