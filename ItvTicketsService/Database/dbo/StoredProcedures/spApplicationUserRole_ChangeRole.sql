CREATE PROCEDURE [dbo].[spApplicationUserRole_ChangeRole]
-- Parameters for Update stored procedure.
@client int,
@role int
AS
BEGIN
-- SQL for Update stored procedure
UPDATE ApplicationUserRole SET RoleId = @role WHERE UserId = @client
END
