﻿/*
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
PRINT N'Modifica di Tabella [dbo].[Tickets]...';


GO
ALTER TABLE [dbo].[Tickets]
    ADD [CloserId] INT NULL;


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Tickets_ToApplicationUserCloser]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK_Tickets_ToApplicationUserCloser] FOREIGN KEY ([CloserId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Modifica di Routine [dbo].[spTicket_GetOne]...';


GO
ALTER PROCEDURE [dbo].[spTicket_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT TOP(1) TicketId, CreatedDate, Reason, DeviceId, TicketStatusId, ClientId, TeamId, OpenDate, TeamMemo, CloseDate, CloserId FROM Tickets WHERE TicketId = @Id
END
GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK_Tickets_ToApplicationUserCloser];


GO
PRINT N'Aggiornamento completato.';


GO
