SET IDENTITY_INSERT [dbo].[TicketStatusMaster] ON
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (1, N'To Do', 0)
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (2, N'InProgress', 0)
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (3, N'Complete', 0)
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (4, N'Approve', 0)
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (5, N'Closed', 0)
INSERT INTO [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (6, N'Aborted', 0)
SET IDENTITY_INSERT [dbo].[TicketStatusMaster] OFF
