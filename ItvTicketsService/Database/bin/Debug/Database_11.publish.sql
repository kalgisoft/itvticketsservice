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
SELECT Id, Code, Type, Info, PlantId FROM Devices WHERE Id= @Id
END
GO
PRINT N'Creazione di Routine [dbo].[spDevice_Insert]...';


GO
CREATE PROCEDURE [dbo].[spDevice_Insert]
--Parameters for Insert stored procedure
@Code NVARCHAR(10),
@Type NVARCHAR(50),
@Info NVARCHAR(50),
@PlantId INT
AS
BEGIN
--SQL for Insert stored procedure
INSERT INTO Devices(Code, Type, Info, PlantId) VALUES (@Code, @Type, @Info, @PlantId)
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
SELECT Id, Code, Type, Info, PlantId FROM Devices ORDER BY Id DESC
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
@PlantId INT
AS
BEGIN
-- SQL for Update stored procedure
UPDATE Devices SET Code = @Code, Type = @Type, Info = @Info, PlantId = @PlantId WHERE Id = @Id
END
GO
PRINT N'Aggiornamento completato.';


GO
