CREATE PROCEDURE [dbo].[spTicket_GetOne]
-- Needs one parameter for primary key
@Id int
AS 
BEGIN
-- SQL Select for one table row
SELECT TOP(1) TicketId, CreatedDate, Reason, DeviceId, TicketStatusId, ClientId, TeamId, OpenDate, TeamMemo, CloseDate, CloserId FROM Tickets WHERE TicketId = @Id
END