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
PRINT N'Modifica di Routine [dbo].[spDeviceInfo_Upsert]...';


GO
ALTER PROCEDURE [dbo].[spDeviceInfo_Upsert]
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
				Data2)  
			VALUES (@Code, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, @p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, @p52, @p53, @p54, @p55)
		END
	SET NOCOUNT OFF;
END
GO
PRINT N'Aggiornamento completato.';


GO
