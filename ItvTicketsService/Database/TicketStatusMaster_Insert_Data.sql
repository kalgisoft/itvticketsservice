SET IDENTITY_INSERT [dbo].[TicketStatusMaster] ON 
GO
INSERT [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (1, N'To Do', 0)
GO
INSERT [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (2, N'InProgress', 0)
GO
INSERT [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (3, N'Complete', 0)
GO
INSERT [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (4, N'Approve', 0)
GO
INSERT [dbo].[TicketStatusMaster] ([TicketStatusId], [TicketStatus], [IsDeleted]) VALUES (5, N'Closed', 0)
GO
SET IDENTITY_INSERT [dbo].[TicketStatusMaster] OFF
GO