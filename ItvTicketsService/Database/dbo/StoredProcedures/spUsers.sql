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
