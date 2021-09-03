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
PRINT N'Modifica di Tabella [dbo].[Devices]...';


GO
ALTER TABLE [dbo].[Devices]
    ADD [NumLinea] INT NULL;


GO
PRINT N'Creazione di Tabella [dbo].[DeviceInfo]...';


GO
CREATE TABLE [dbo].[DeviceInfo] (
    [Code]                 NCHAR (10)     NOT NULL,
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
PRINT N'Aggiornamento completato.';


GO
