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
/*
La colonna [dbo].[ApplicationUser].[CompanyName] viene eliminata. Possibile perdita dati.
*/

IF EXISTS (select top 1 1 from [dbo].[ApplicationUser])
    RAISERROR (N'Rilevate righe. L''aggiornamento dello schema verrà interrotto perché potrebbe verificarsi la perdita di dati.', 16, 127) WITH NOWAIT

GO
PRINT N'Modifica di Tabella [dbo].[ApplicationUser]...';


GO
ALTER TABLE [dbo].[ApplicationUser] DROP COLUMN [CompanyName];


GO
ALTER TABLE [dbo].[ApplicationUser]
    ADD [PlantId] INT NULL;


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUser_ToPlant]...';


GO
ALTER TABLE [dbo].[ApplicationUser] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUser_ToPlant] FOREIGN KEY ([PlantId]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[ApplicationUser] WITH CHECK CHECK CONSTRAINT [FK_ApplicationUser_ToPlant];


GO
PRINT N'Aggiornamento completato.';


GO
