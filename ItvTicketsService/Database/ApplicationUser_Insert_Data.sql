SET IDENTITY_INSERT [dbo].[ApplicationUser] ON 

GO
INSERT [dbo].[ApplicationUser] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [CompanyName]) VALUES (1, N'admin', N'ADMIN', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEPdzMuF7Ad3Mbk7E4hqJf1VYapigZeI6I0QEsmbiAnRsGkMmGoAm0iiD4Rff9IyAow==', NULL, 0, 0, N'Royal LLC')
GO
INSERT [dbo].[ApplicationUser] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [CompanyName]) VALUES (2, N'Clientuser', N'CLIENTUSER', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEPepsDMLTfOGMCKj8d3hDsRLdxBcatwTD8kcdL7kXbfkLoTPnx/0mzsiQ2lgeb2+sw==', NULL, 0, 0, N'Royal LLC')
GO
SET IDENTITY_INSERT [dbo].[ApplicationUser] OFF
GO