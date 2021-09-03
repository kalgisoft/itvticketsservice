SET IDENTITY_INSERT [dbo].[ApplicationRole] ON 

GO
INSERT [dbo].[ApplicationRole] ([Id], [Name], [NormalizedName]) VALUES (1, N'Admin', N'ADMIN')
GO
INSERT [dbo].[ApplicationRole] ([Id], [Name], [NormalizedName]) VALUES (2, N'Client', N'CLIENT')
GO
SET IDENTITY_INSERT [dbo].[ApplicationRole] OFF
GO