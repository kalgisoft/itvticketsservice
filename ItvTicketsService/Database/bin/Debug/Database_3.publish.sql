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
SELECT Id, StreetAddress, City, State, ZipCode, Email, Phone, TicketAmount FROM Company WHERE Id= @Id
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
SELECT TOP 30 Id, StreetAddress, City, State, ZipCode, Email FROM Company ORDER BY Id DESC
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
PRINT N'Aggiornamento completato.';


GO
