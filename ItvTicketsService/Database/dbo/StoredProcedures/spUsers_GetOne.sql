CREATE PROCEDURE [dbo].[spUsers_GetOne]
-- Needs one parameter for primary key
@client int
AS 
BEGIN
-- SQL Select for one table row
-- SELECT Id, UserName FROM ApplicationUser WHERE Id = @Id
SELECT A.Id, A.UserName, B.RoleId as UserRole
FROM ApplicationUser A, ApplicationUserRole B
WHERE A.Id = @client AND A.Id = B.UserId
END