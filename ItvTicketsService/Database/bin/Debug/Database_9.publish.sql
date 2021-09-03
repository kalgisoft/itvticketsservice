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
PRINT N'Aggiornamento completato.';


GO
