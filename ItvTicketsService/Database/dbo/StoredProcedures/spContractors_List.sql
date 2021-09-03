CREATE PROCEDURE [dbo].[spContractors_List]
--No parameters required.
AS
BEGIN
--SQL for Select stored procedure.
SELECT Id, Name FROM Contractors ORDER BY Id DESC
END

