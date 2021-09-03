CREATE PROCEDURE [dbo].[spUsers_GetRole]
-- Needs one parameter for primary key
@userId int
AS 
BEGIN
-- SQL Select for one table row
SELECT RoleId FROM ApplicationUserRole WHERE UserId = @userId
END
