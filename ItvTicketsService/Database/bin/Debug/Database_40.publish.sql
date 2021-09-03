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
PRINT N'L''operazione di refactoring Sposta schema con la chiave 5b139cb4-87b2-41e4-8e20-f88bc66193ca viene ignorata. L''elemento [dbo].[Company].[E-mail] (SqlSimpleColumn) non verrà rinominato in Email';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave a2a510dd-153b-4a2d-80a2-a4cec5a993e4 viene ignorata. L''elemento [dbo].[ApplicationUser].[CompanyName] (SqlSimpleColumn) non verrà rinominato in PlantId';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave f1b73fde-ae1b-48a0-bf18-0cc140fd05e8 viene ignorata. L''elemento [dbo].[Tickets].[UserId] (SqlSimpleColumn) non verrà rinominato in ClientId';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 1b3c3b13-5b65-4ad6-89cd-0004245b3cc6, b2a07649-9cd4-4dce-8f3b-6adf2055d749 viene ignorata. L''elemento [dbo].[Tickets].[EndDate] (SqlSimpleColumn) non verrà rinominato in OpenDate';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 18ead57e-2df1-4922-b3d6-ad94656079e4 viene ignorata. L''elemento [dbo].[Tickets].[OpenerId] (SqlSimpleColumn) non verrà rinominato in CloseDate';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave a845e822-7e77-4af8-a227-b70be86fa694 viene ignorata. L''elemento [dbo].[Tickets].[CompanyName] (SqlSimpleColumn) non verrà rinominato in DeviceId';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 0d102c9e-8a37-4bb3-970e-ca89a87d2735 viene ignorata. L''elemento [dbo].[DeviceInfo].[Id] (SqlSimpleColumn) non verrà rinominato in Code';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 2beadbeb-2b9b-40d8-a958-c073066b281f viene ignorata. L''elemento [dbo].[DeviceInfo].[Ciente] (SqlSimpleColumn) non verrà rinominato in Cliente';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 4f12a69d-4ab5-4748-9127-2b2811d3fd01 viene ignorata. L''elemento [dbo].[PlantsToClient].[Id] (SqlSimpleColumn) non verrà rinominato in IdClient';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 466e184f-9cc3-42b8-a711-6c958d45266b viene ignorata. L''elemento [dbo].[LogTable].[Id] (SqlSimpleColumn) non verrà rinominato in LogId';


GO
PRINT N'L''operazione di refactoring Sposta schema con la chiave 9ddb58b5-4e58-4763-96c0-0fc409c04ed5 viene ignorata. L''elemento [dbo].[LogTable].[Stacktrace] (SqlSimpleColumn) non verrà rinominato in StackTrace';


GO
PRINT N'Creazione di Tabella [dbo].[LogTable]...';


GO
CREATE TABLE [dbo].[LogTable] (
    [LogId]            INT  IDENTITY (1, 1) NOT NULL,
    [LogLevel]         TEXT NULL,
    [EventName]        TEXT NULL,
    [Source]           TEXT NULL,
    [ExceptionMessage] TEXT NULL,
    [StackTrace]       TEXT NULL,
    [CreatedDate]      TEXT NULL,
    [UserId]           INT  NULL,
    PRIMARY KEY CLUSTERED ([LogId] ASC)
);


GO
PRINT N'Creazione di Routine [dbo].[spLog_Delete]...';


GO
CREATE PROCEDURE [dbo].[spLog_Delete]
@LogId int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM LogTable WHERE LogId = @LogId
END
GO
PRINT N'Creazione di Routine [dbo].[spLog_GetOne]...';


GO
CREATE PROCEDURE [dbo].[spLog_GetOne]
-- Needs one parameter for primary key
@LogId int
AS 
BEGIN
-- SQL Select for one table row
SELECT LogId, LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId FROM LogTable WHERE LogId = @LogId
END
GO
PRINT N'Creazione di Routine [dbo].[spLog_Insert]...';


GO
CREATE PROCEDURE [dbo].[spLog_Insert]
@LogLevel text,
@EventName text,
@Source text,
@ExceptionMessage text,
@StackTrace text,
@CreatedDate text,
@UserId INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO LogTable(LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId) VALUES (@LogLevel, @EventName, @Source, @ExceptionMessage, @StackTrace, @CreatedDate, @UserId)
RETURN SCOPE_IDENTITY()
END
GO
PRINT N'Creazione di Routine [dbo].[spLog_List]...';


GO
CREATE PROCEDURE [dbo].[spLog_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT LogId, LogLevel, EventName, Source, ExceptionMessage, StackTrace, CreatedDate, UserId FROM LogTable ORDER BY LogId DESC
END
GO
-- Refactoring del passaggio per aggiornare il server di destinazione con i log delle transazioni distribuiti

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '5b139cb4-87b2-41e4-8e20-f88bc66193ca')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('5b139cb4-87b2-41e4-8e20-f88bc66193ca')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a2a510dd-153b-4a2d-80a2-a4cec5a993e4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a2a510dd-153b-4a2d-80a2-a4cec5a993e4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f1b73fde-ae1b-48a0-bf18-0cc140fd05e8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f1b73fde-ae1b-48a0-bf18-0cc140fd05e8')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '1b3c3b13-5b65-4ad6-89cd-0004245b3cc6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('1b3c3b13-5b65-4ad6-89cd-0004245b3cc6')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'b2a07649-9cd4-4dce-8f3b-6adf2055d749')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('b2a07649-9cd4-4dce-8f3b-6adf2055d749')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '18ead57e-2df1-4922-b3d6-ad94656079e4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('18ead57e-2df1-4922-b3d6-ad94656079e4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a845e822-7e77-4af8-a227-b70be86fa694')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a845e822-7e77-4af8-a227-b70be86fa694')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '0d102c9e-8a37-4bb3-970e-ca89a87d2735')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('0d102c9e-8a37-4bb3-970e-ca89a87d2735')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2beadbeb-2b9b-40d8-a958-c073066b281f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2beadbeb-2b9b-40d8-a958-c073066b281f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4f12a69d-4ab5-4748-9127-2b2811d3fd01')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4f12a69d-4ab5-4748-9127-2b2811d3fd01')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '466e184f-9cc3-42b8-a711-6c958d45266b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('466e184f-9cc3-42b8-a711-6c958d45266b')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '9ddb58b5-4e58-4763-96c0-0fc409c04ed5')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('9ddb58b5-4e58-4763-96c0-0fc409c04ed5')

GO

GO
PRINT N'Aggiornamento completato.';


GO
