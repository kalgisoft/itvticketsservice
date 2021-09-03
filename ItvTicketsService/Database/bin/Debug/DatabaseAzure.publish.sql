/*
Script di distribuzione per itv_ticket_db

Questo codice è stato generato da uno strumento.
Le modifiche apportate al file possono causare un comportamento non corretto e verranno perse se
il codice viene rigenerato.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "itv_ticket_db"
:setvar DefaultFilePrefix "itv_ticket_db"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

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
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
    END


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
    [PlantId]              INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


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
PRINT N'Creazione di Tabella [dbo].[DeviceInfo]...';


GO
CREATE TABLE [dbo].[DeviceInfo] (
    [Code]                 NVARCHAR (10)  NOT NULL,
    [TipoMacchina]         NVARCHAR (50)  NULL,
    [SensoDiMarcia]        NVARCHAR (50)  NULL,
    [Matricola]            NVARCHAR (50)  NULL,
    [Cliente]              NVARCHAR (50)  NULL,
    [CommessaNr]           NVARCHAR (50)  NULL,
    [DataCollaudo]         DATETIME       NULL,
    [DataConsegna]         DATETIME       NULL,
    [CompilatoDa]          NVARCHAR (50)  NULL,
    [Data]                 DATETIME       NULL,
    [TipoPC]               NVARCHAR (50)  NULL,
    [HardDisk]             NVARCHAR (50)  NULL,
    [RAM]                  NVARCHAR (50)  NULL,
    [Grabber]              NVARCHAR (50)  NULL,
    [NumLed]               INT            NULL,
    [TipoLedD]             NVARCHAR (50)  NULL,
    [TipoLedN]             NVARCHAR (50)  NULL,
    [DistanzaIlluminatore] INT            NULL,
    [Note1]                NVARCHAR (256) NULL,
    [RealizzatoDa]         NVARCHAR (50)  NULL,
    [Data1]                DATETIME       NULL,
    [QuadroRealDa]         NVARCHAR (50)  NULL,
    [NumSchemaEl]          INT            NULL,
    [installRealDa]        NVARCHAR (50)  NULL,
    [GruppoCont]           NVARCHAR (50)  NULL,
    [CollaudoRealDa]       NVARCHAR (50)  NULL,
    [Condizionatore]       NVARCHAR (50)  NULL,
    [Note2]                NVARCHAR (256) NULL,
    [VerSWTilevision]      NVARCHAR (50)  NULL,
    [VerSWCalibroPlanar]   NVARCHAR (50)  NULL,
    [NumSensPlanar]        INT            NULL,
    [TipoSens]             NVARCHAR (50)  NULL,
    [NoteAggiuntive]       NVARCHAR (50)  NULL,
    [NomePC]               NVARCHAR (50)  NULL,
    [TipoCinghia]          NVARCHAR (50)  NULL,
    [LargCinghia]          NVARCHAR (50)  NULL,
    [TipoMotori]           NVARCHAR (50)  NULL,
    [TipoRiduttori]        NVARCHAR (50)  NULL,
    [TipoMarcatura]        NVARCHAR (50)  NULL,
    [Centratore]           NVARCHAR (50)  NULL,
    [MotoreMovTraverse]    NVARCHAR (50)  NULL,
    [TipoEncoder]          NVARCHAR (50)  NULL,
    [TipoAzionamenti]      NVARCHAR (50)  NULL,
    [MassimoFormato]       INT            NULL,
    [MinimoFormato]        INT            NULL,
    [TipoMotoriTLC]        NVARCHAR (50)  NULL,
    [AltezzaTlcN]          INT            NULL,
    [TipoTlcN]             NVARCHAR (50)  NULL,
    [TipoTlcD]             NVARCHAR (50)  NULL,
    [TipoObjN]             NVARCHAR (50)  NULL,
    [TipoObjD]             NVARCHAR (50)  NULL,
    [AperturaObjN]         NVARCHAR (50)  NULL,
    [AperturaObjD]         NVARCHAR (50)  NULL,
    [Note3]                NVARCHAR (256) NULL,
    [MontaggioDa]          NVARCHAR (50)  NULL,
    [Data2]                DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[Devices]...';


GO
CREATE TABLE [dbo].[Devices] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Code]     NCHAR (10)    NOT NULL,
    [Type]     NVARCHAR (50) NULL,
    [Info]     NVARCHAR (50) NULL,
    [PlantId]  INT           NULL,
    [NumLinea] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creazione di Tabella [dbo].[Plant]...';


GO
CREATE TABLE [dbo].[Plant] (
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


GO
PRINT N'Creazione di Tabella [dbo].[Tickets]...';


GO
CREATE TABLE [dbo].[Tickets] (
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
    [CloserId]       INT           NULL,
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
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUser_ToPlant]...';


GO
ALTER TABLE [dbo].[ApplicationUser] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUser_ToPlant] FOREIGN KEY ([PlantId]) REFERENCES [dbo].[Plant] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUserRole_Role]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[ApplicationRole] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK_ApplicationUserRole_User]...';


GO
ALTER TABLE [dbo].[ApplicationUserRole] WITH NOCHECK
    ADD CONSTRAINT [FK_ApplicationUserRole_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


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
PRINT N'Creazione di Chiave esterna [dbo].[FK_Tickets_ToApplicationUserCloser]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK_Tickets_ToApplicationUserCloser] FOREIGN KEY ([CloserId]) REFERENCES [dbo].[ApplicationUser] ([Id]);


GO
PRINT N'Creazione di Chiave esterna [dbo].[FK__Tickets__TicketStatusMaster]...';


GO
ALTER TABLE [dbo].[Tickets] WITH NOCHECK
    ADD CONSTRAINT [FK__Tickets__TicketStatusMaster] FOREIGN KEY ([TicketStatusId]) REFERENCES [dbo].[TicketStatusMaster] ([TicketStatusId]);


GO
PRINT N'Creazione di Routine [dbo].[spCompany_Delete]...';


GO
--------------  Stored Proc for DELETE
CREATE PROCEDURE spCompany_Delete
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Company WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spCompany_GetOne]...';


GO
--------------  Stored Proc for SELECT (one)
CREATE PROCEDURE spCompany_GetOne
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount FROM Company WHERE Id= @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spCompany_Insert]...';


GO
CREATE PROCEDURE spCompany_Insert
--Parameters for Insert stored procedure
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@TicketAmount INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Company(Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount) VALUES (@Name, @StreetAddress, @City, @State, @ZipCode, @Email, @Phone, @TicketAmount)
RETURN SCOPE_IDENTITY()
END
GO
PRINT N'Creazione di Routine [dbo].[spCompany_List]...';


GO
--------------  Stored Proc for SELECT
CREATE PROCEDURE spCompany_List
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount FROM Company ORDER BY Id DESC
END
GO
PRINT N'Creazione di Routine [dbo].[spCompany_Update]...';


GO
--------------  Stored Proc for UPDATE
CREATE PROCEDURE spCompany_Update
-- Parameters for Update stored procedure.
@iD int,
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@TicketAmount INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Company SET Name = @Name, StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode, Email = @Email, Phone = @Phone, TicketAmount = @TicketAmount WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_Delete]...';


GO
CREATE PROCEDURE [dbo].[spDevice_Delete]
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Devices WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_GetOne]...';


GO
CREATE PROCEDURE [dbo].[spDevice_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Code, Type, Info, PlantId, NumLinea FROM Devices WHERE Id= @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_Insert]...';


GO
CREATE PROCEDURE [dbo].[spDevice_Insert]
--Parameters for Insert stored procedure
@Code NVARCHAR(10),
@Type NVARCHAR(50),
@Info NVARCHAR(50),
@PlantId INT,
@NumLinea INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Devices(Code, Type, Info, PlantId, NumLinea) VALUES (@Code, @Type, @Info, @PlantId, @NumLinea)
RETURN SCOPE_IDENTITY()
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_List]...';


GO
CREATE PROCEDURE [dbo].[spDevice_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Code, Type, Info, PlantId, NumLinea FROM Devices ORDER BY Id DESC
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_Update]...';


GO
CREATE PROCEDURE [dbo].[spDevice_Update]
-- Parameters for Update stored procedure.
@iD int,
@Code NVARCHAR(10),
@Type NVARCHAR(50),
@Info NVARCHAR(50),
@PlantId INT,
@NumLinea INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Devices SET Code = @Code, Type = @Type, Info = @Info, PlantId = @PlantId, NumLinea = @NumLinea WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spDeviceInfo_Upsert]...';


GO
CREATE PROCEDURE [dbo].[spDeviceInfo_Upsert]
	@Code NVARCHAR(10),
	@p1 NVARCHAR(50),
	@p2 NVARCHAR(50),
	@p3 NVARCHAR(50),
	@p4 NVARCHAR(50),
	@p5 NVARCHAR(50),
	@p6 DATETIME,
	@p7 DATETIME,
	@p8 NVARCHAR(50),
	@p9 DATETIME,
	@p10 NVARCHAR(50),
	@p11 NVARCHAR(50),
	@p12 NVARCHAR(50),
	@p13 NVARCHAR(50),
	@p14 INT,
	@p15 NVARCHAR(50),
	@p16 NVARCHAR(50),
	@p17 INT,
	@p18 NVARCHAR(256),
	@p19 NVARCHAR(50),
	@p20 DATETIME,
	@p21 NVARCHAR(50),
	@p22 INT,
	@p23 NVARCHAR(50),
	@p24 NVARCHAR(50),
	@p25 NVARCHAR(50),
	@p26 NVARCHAR(50),
	@p27 NVARCHAR(256),
	@p28 NVARCHAR(50),
	@p29 NVARCHAR(50),
	@p30 INT,
	@p31 NVARCHAR(50),
	@p32 NVARCHAR(50),
	@p33 NVARCHAR(50),
	@p34 NVARCHAR(50),
	@p35 NVARCHAR(50),
	@p36 NVARCHAR(50),
	@p37 NVARCHAR(50),
	@p38 NVARCHAR(50),
	@p39 NVARCHAR(50),
	@p40 NVARCHAR(50),
	@p41 NVARCHAR(50),
	@p42 NVARCHAR(50),
	@p43 INT,
	@p44 INT,
	@p45 NVARCHAR(50),
	@p46 INT,
	@p47 NVARCHAR(50),
	@p48 NVARCHAR(50),
	@p49 NVARCHAR(50),
	@p50 NVARCHAR(50),
	@p51 NVARCHAR(50),
	@p52 NVARCHAR(50),
	@p53 NVARCHAR(256),
	@p54 NVARCHAR(50),
	@p55 DATETIME
AS
BEGIN  
    SET NOCOUNT ON;

-- Update the row if it exists.
    UPDATE DeviceInfo
	SET
	TipoMacchina = @p1,
    SensoDiMarcia = @p2,
	Matricola = @p3,
	Cliente = @p4,
    CommessaNr = @p5,
    DataCollaudo = @p6,
    DataConsegna = @p7,
    CompilatoDa = @p8,
    Data = @p9,
    TipoPC = @p10,
	HardDisk = @p11,
    RAM = @p12,
	Grabber = @p13,
	NumLed = @p14,
    TipoLedD = @p15,
    TipoLedN = @p16,
    DistanzaIlluminatore = @p17,
    Note1 = @p18,
    RealizzatoDa = @p19,
    Data1 = @p20,
	QuadroRealDa = @p21,
    NumSchemaEl = @p22,
	installRealDa = @p23,
	GruppoCont = @p24,
    CollaudoRealDa = @p25,
    Condizionatore = @p26,
    Note2 = @p27,
    VerSWTilevision = @p28,
    VerSWCalibroPlanar = @p29,
    NumSensPlanar = @p30,
	TipoSens = @p31,
    NoteAggiuntive = @p32,
	NomePC = @p33,
	TipoCinghia = @p34,
    LargCinghia = @p35,
    TipoMotori = @p36,
    TipoRiduttori = @p37,
    TipoMarcatura = @p38,
    Centratore = @p39,
    MotoreMovTraverse = @p40,
	TipoEncoder = @p41,
    TipoAzionamenti = @p42,
	MassimoFormato = @p43,
	MinimoFormato = @p44,
    TipoMotoriTLC = @p45,
    AltezzaTlcN = @p46,
    TipoTlcN = @p47,
    TipoTlcD = @p48,
    TipoObjN = @p49,
    TipoObjD = @p50,
	AperturaObjN = @p51,
    AperturaObjD = @p52,
	Note3 = @p53,
	MontaggioDa = @p54,
	Data2 = @p55
	WHERE Code = @Code

-- Insert the row if the UPDATE statement failed.  
	IF (@@ROWCOUNT = 0 )  
		BEGIN  
			INSERT INTO DeviceInfo (Code,
				TipoMacchina,
				SensoDiMarcia,
				Matricola,
				Cliente,
				CommessaNr,
				DataCollaudo,
				DataConsegna,
				CompilatoDa,
				Data,
				TipoPC,
				HardDisk,
				RAM,
				Grabber,
				NumLed,
				TipoLedD,
				TipoLedN,
				DistanzaIlluminatore,
				Note1,
				RealizzatoDa,
				Data1,
				QuadroRealDa,
				NumSchemaEl,
				installRealDa,
				GruppoCont,
				CollaudoRealDa,
				Condizionatore,
				Note2,
				VerSWTilevision,
				VerSWCalibroPlanar,
				NumSensPlanar,
				TipoSens,
				NoteAggiuntive,
				NomePC,
				TipoCinghia,
				LargCinghia,
				TipoMotori,
				TipoRiduttori,
				TipoMarcatura,
				Centratore,
				MotoreMovTraverse,
				TipoEncoder,
				TipoAzionamenti,
				MassimoFormato,
				MinimoFormato,
				TipoMotoriTLC,
				AltezzaTlcN,
				TipoTlcN,
				TipoTlcD,
				TipoObjN,
				TipoObjD,
				AperturaObjN,
				AperturaObjD,
				Note3,
				MontaggioDa,
				Data2
				)
			VALUES (@Code, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, @p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, @p52, @p53, @p54, @p55)
		END
	SET NOCOUNT OFF;
END
GO
PRINT N'Creazione di Routine [dbo].[spPlant_Delete]...';


GO
CREATE PROCEDURE [dbo].[spPlant_Delete]
-- One parameter required to identify row to delete.
@Id int
AS
BEGIN
-- SQL for Delete stored procedure (physically deletes, you may want to change this to mark inactive)
DELETE FROM Plant WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spPlant_GetOne]...';


GO
CREATE PROCEDURE [dbo].[spPlant_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany FROM Plant WHERE Id= @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spPlant_Insert]...';


GO
CREATE PROCEDURE [dbo].[spPlant_Insert]
--Parameters for Insert stored procedure
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@IdCompany INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Plant(Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany) VALUES (@name, @StreetAddress, @City, @State, @ZipCode, @Email, @Phone, @IdCompany)
RETURN SCOPE_IDENTITY()
END
GO
PRINT N'Creazione di Routine [dbo].[spPlant_List]...';


GO
CREATE PROCEDURE [dbo].[spPlant_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name, StreetAddress, City, State, ZipCode, Email, Phone, IdCompany FROM Plant ORDER BY Id DESC
END
GO
PRINT N'Creazione di Routine [dbo].[spPlant_Update]...';


GO
CREATE PROCEDURE [dbo].[spPlant_Update]
-- Parameters for Update stored procedure.
@iD int,
@Name NVARCHAR(50),
@StreetAddress NVARCHAR(50),
@City NVARCHAR(50),
@State NVARCHAR(50),
@ZipCode NVARCHAR(50),
@Email NVARCHAR(50),
@Phone NVARCHAR(50),
@IdCompany INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Plant SET Name = @Name, StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode, Email = @Email, Phone = @Phone, IdCompany = @IdCompany WHERE Id = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spTicket_GetOne]...';


GO
CREATE PROCEDURE [dbo].[spTicket_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT TOP(1) TicketId, CreatedDate, Reason, DeviceId, TicketStatusId, ClientId, TeamId, OpenDate, TeamMemo, CloseDate, CloserId FROM Tickets WHERE TicketId = @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spUsers]...';


GO
CREATE PROCEDURE [dbo].[spUsers]
@NNAME NVARCHAR(256)
AS
BEGIN
SELECT u.Id, u.UserName, u.PlantId FROM [ApplicationUser] u
INNER JOIN [ApplicationUserRole] ur ON ur.[UserId] = u.[Id]
INNER JOIN [ApplicationRole] r ON r.[Id] = ur.[RoleId] 
WHERE r.[NormalizedName] = @NNAME
ORDER BY u.Id DESC
END
GO
