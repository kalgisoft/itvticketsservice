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
PRINT N'Modifica di Routine [dbo].[spUsers_GetOne]...';


GO
ALTER PROCEDURE [dbo].[spUsers_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
-- SELECT Id, UserName FROM ApplicationUser WHERE Id = @Id
SELECT A.Id, A.UserName, B.RoleId
FROM ApplicationUser A, ApplicationUserRole B
WHERE A.Id = B.UserId
END
GO
PRINT N'Creazione di Routine [dbo].[spUsers_GetRole]...';


GO
CREATE PROCEDURE [dbo].[spUsers_GetRole]
-- Needs one parameter for primary key
@userId int
AS 
BEGIN
-- SQL Select for one table row
SELECT RoleId FROM ApplicationUserRole WHERE UserId = @userId
END
GO
PRINT N'Aggiornamento completato.';


GO
