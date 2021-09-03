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
/*
La colonna [dbo].[Tickets].[CompanyName] viene eliminata. Possibile perdita dati.

La colonna [dbo].[Tickets].[EndDate] viene eliminata. Possibile perdita dati.

La colonna [dbo].[Tickets].[OpenerId] viene eliminata. Possibile perdita dati.

La colonna [dbo].[Tickets].[UserId] viene eliminata. Possibile perdita dati.
*/

IF EXISTS (select top 1 1 from [dbo].[Tickets])
    RAISERROR (N'Rilevate righe. L''aggiornamento dello schema verrà interrotto perché potrebbe verificarsi la perdita di dati.', 16, 127) WITH NOWAIT

GO
PRINT N'Eliminazione di Chiave esterna [dbo].[FK__Tickets__TicketStatusMaster]...';


GO
ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK__Tickets__TicketStatusMaster];


GO
PRINT N'Avvio ricompilazione tabella [dbo].[Tickets]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Tickets] (
    [TicketId]       INT           IDENTITY (1, 1) NOT NULL,
    [CreatedDate]    DATETIME      NOT NULL,
    [Reason]         VARCHAR (255) NULL,
    [DeviceId]       INT           NULL,
    [TicketStatusId] INT           NOT NULL,
    [ClientId]       INT           NULL,
    [TeamId]         INT           NULL,
    [OpenDate]       DATETIME      NULL,
    [TeamMemo]       TEXT          NULL,
    [CloseDate]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([TicketId] ASC) ON [PRIMARY]
) ON [PRIMARY];

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Tickets])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Tickets] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Tickets] ([TicketId], [CreatedDate], [Reason], [TicketStatusId], [TeamId], [TeamMemo])
        SELECT   [TicketId],
                 [CreatedDate],
                 [Reason],
                 [TicketStatusId],
                 [TeamId],
                 [TeamMemo]
        FROM     [dbo].[Tickets]
        ORDER BY [TicketId] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Tickets] OFF;
    END

DROP TABLE [dbo].[Tickets];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Tickets]', N'Tickets';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK__Tickets__TicketStatusMaster]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK__Tickets__TicketStatusMaster] FOREIGN KEY ([TicketStatusId]) REFERENCES [dbo].[TicketStatusMaster] ([TicketStatusId]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Tickets_ToApplicationUserClient]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK_Tickets_ToApplicationUserClient] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Tickets_ToApplicationUserTeam]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK_Tickets_ToApplicationUserTeam] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Tickets_ToDevices]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK_Tickets_ToDevices] FOREIGN KEY ([DeviceId]) REFERENCES [dbo].[Devices] ([Id]);


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK__Tickets__TicketStatusMaster];

ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK_Tickets_ToApplicationUserClient];

ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK_Tickets_ToApplicationUserTeam];

ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK_Tickets_ToDevices];


GO
PRINT N'Aggiornamento completato.';


GO
