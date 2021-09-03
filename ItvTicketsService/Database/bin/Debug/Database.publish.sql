/*
Script di distribuzione per TestDatabase

Questo codice è stato generato da uno strumento.
Le modifiche apportate al file possono causare un comportamento non corretto e verranno perse se
il codice viene rigenerato.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "TestDatabase"
:setvar DefaultFilePrefix "TestDatabase"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\"

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
            SET PAGE_VERIFY NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Creazione di [dbo].[ApplicationRole]...';


GO
CREATE TABLE [dbo].[ApplicationRole] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (256) NOT NULL,
    [NormalizedName] NVARCHAR (256) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di [dbo].[ApplicationUser]...';


GO
CREATE TABLE [dbo].[ApplicationUser] (
    [Id]                   INT            IDENTITY (1, 1) NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    [NormalizedUserName]   NVARCHAR (256) NOT NULL,
    [Email]                NVARCHAR (256) NULL,
    [NormalizedEmail]      NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (50)  NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [CompanyName]          VARCHAR (255)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];


GO
PRINT N'Creazione di [dbo].[ApplicationUserRole]...';


GO
CREATE TABLE [dbo].[ApplicationUserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di [dbo].[Tickets]...';


GO
CREATE TABLE [dbo].[Tickets] (
    [TicketId]       INT           IDENTITY (1, 1) NOT NULL,
    [CreatedDate]    DATETIME      NOT NULL,
    [Reason]         VARCHAR (255) NOT NULL,
    [CompanyName]    VARCHAR (255) NULL,
    [TicketStatusId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([TicketId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di [dbo].[TicketStatusMaster]...';


GO
CREATE TABLE [dbo].[TicketStatusMaster] (
    [TicketStatusId] INT          IDENTITY (1, 1) NOT NULL,
    [TicketStatus]   VARCHAR (20) NULL,
    [IsDeleted]      BIT          NULL,
    CONSTRAINT [PK_TicketStatusMaster] PRIMARY KEY CLUSTERED ([TicketStatusId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di [dbo].[DF_TicketStatusMaster_IsDeleted]...';


GO
ALTER TABLE [dbo].[TicketStatusMaster]
    ADD CONSTRAINT [DF_TicketStatusMaster_IsDeleted] DEFAULT ((0)) FOR [IsDeleted];


GO
PRINT N'Creazione di [dbo].[FK_ApplicationUserRole_Role]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[ApplicationRole] ([Id]);


GO
PRINT N'Creazione di [dbo].[FK_ApplicationUserRole_User]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUserRole_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di [dbo].[FK__Tickets__TicketStatusMaster]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK__Tickets__TicketStatusMaster] FOREIGN KEY ([TicketStatusId]) REFERENCES [dbo].[TicketStatusMaster] ([TicketStatusId]);


GO
PRINT N'Verifica dei dati esistenti rispetto ai vincoli appena creati';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[ApplicationUserRole] WITH CHECK CHECK CONSTRAINT [FK_ApplicationUserRole_Role];

ALTER TABLE [dbo].[ApplicationUserRole] WITH CHECK CHECK CONSTRAINT [FK_ApplicationUserRole_User];

ALTER TABLE [dbo].[Tickets] WITH CHECK CHECK CONSTRAINT [FK__Tickets__TicketStatusMaster];


GO
PRINT N'Aggiornamento completato.';


GO
