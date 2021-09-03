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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creazione del database $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'Impossibile modificare le impostazioni di database. È necessario appartenere al ruolo SysAdmin per applicare queste impostazioni.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'Impossibile modificare le impostazioni di database. È necessario appartenere al ruolo SysAdmin per applicare queste impostazioni.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creazione di Tabella [dbo].[ApplicationRole]...';


GO
CREATE TABLE [dbo].[ApplicationRole] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (256) NOT NULL,
    [NormalizedName] NVARCHAR (256) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di Tabella [dbo].[ApplicationUser]...';


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
PRINT N'Creazione di Tabella [dbo].[ApplicationUserRole]...';


GO
CREATE TABLE [dbo].[ApplicationUserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di Tabella [dbo].[Company]...';


GO
CREATE TABLE [dbo].[Company] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [StreetAddress] NVARCHAR (50) NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         NVARCHAR (50) NULL,
    [ZipCode]       NVARCHAR (50) NULL,
    [Email]         NVARCHAR (50) NULL,
    [Phone]         NVARCHAR (50) NULL,
    [TicketAmount]  INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[Devices]...';


GO
CREATE TABLE [dbo].[Devices] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Code]    NCHAR (10)    NOT NULL,
    [Type]    NVARCHAR (50) NULL,
    [Info]    NVARCHAR (50) NULL,
    [PlantId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[Plant]...';


GO
CREATE TABLE [dbo].[Plant] (
    [Id]            INT           NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [StreetAddress] NVARCHAR (50) NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         NVARCHAR (50) NULL,
    [ZipCode]       NVARCHAR (50) NULL,
    [Email]         NVARCHAR (50) NULL,
    [Phone]         NVARCHAR (50) NULL,
    [IdCompany]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[Tickets]...';


GO
CREATE TABLE [dbo].[Tickets] (
    [TicketId]       INT           IDENTITY (1, 1) NOT NULL,
    [CreatedDate]    DATETIME      NOT NULL,
    [Reason]         VARCHAR (255) NULL,
    [CompanyName]    VARCHAR (255) NULL,
    [TicketStatusId] INT           NOT NULL,
    [UserId]         INT           NOT NULL,
    [TeamId]         INT           NULL,
    [EndDate]        DATETIME      NULL,
    [TeamMemo]       TEXT          NULL,
    [OpenerId]       INT           NULL,
    PRIMARY KEY CLUSTERED ([TicketId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di Tabella [dbo].[TicketStatusMaster]...';


GO
CREATE TABLE [dbo].[TicketStatusMaster] (
    [TicketStatusId] INT          IDENTITY (1, 1) NOT NULL,
    [TicketStatus]   VARCHAR (20) NULL,
    [IsDeleted]      BIT          NULL,
    CONSTRAINT [PK_TicketStatusMaster] PRIMARY KEY CLUSTERED ([TicketStatusId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creazione di Vincolo predefinito [dbo].[DF_TicketStatusMaster_IsDeleted]...';


GO
ALTER TABLE [dbo].[TicketStatusMaster]
    ADD CONSTRAINT [DF_TicketStatusMaster_IsDeleted] DEFAULT ((0)) FOR [IsDeleted];


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUserRole_Role]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole]
    ADD CONSTRAINT [FK_ApplicationUserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[ApplicationRole] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUserRole_User]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole]
    ADD CONSTRAINT [FK_ApplicationUserRole_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Devices_Plant]...';


GO
ALTER TABLE [dbo].[Devices]
    ADD CONSTRAINT [FK_Devices_Plant] FOREIGN KEY ([PlantId]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_Plant_Company]...';


GO
ALTER TABLE [dbo].[Plant]
    ADD CONSTRAINT [FK_Plant_Company] FOREIGN KEY ([IdCompany]) REFERENCES [dbo].[Company] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK__Tickets__TicketStatusMaster]...';


GO
ALTER TABLE [dbo].[Tickets]
    ADD CONSTRAINT [FK__Tickets__TicketStatusMaster] FOREIGN KEY ([TicketStatusId]) REFERENCES [dbo].[TicketStatusMaster] ([TicketStatusId]);


GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Aggiornamento completato.';


GO
