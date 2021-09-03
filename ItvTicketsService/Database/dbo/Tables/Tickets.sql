
CREATE TABLE [dbo].[Tickets](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Reason] [varchar](255) NULL,
	[DeviceId] INT NULL,
	[TicketStatusId] [int] NOT NULL,
	[ClientId] INT NULL, 
    [TeamId] INT NULL, 
    [OpenDate] DATETIME NULL, 
    [TeamMemo] TEXT NULL, 
    [CloseDate] DATETIME NULL, 
    [CloserId] INT NULL, 
    PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_Tickets_ToApplicationUserClient] FOREIGN KEY ([ClientId]) REFERENCES [ApplicationUser]([Id]), 
    CONSTRAINT [FK_Tickets_ToApplicationUserTeam] FOREIGN KEY ([TeamId]) REFERENCES [ApplicationUser]([Id]), 
    CONSTRAINT [FK_Tickets_ToDevices] FOREIGN KEY ([deviceId]) REFERENCES [Devices]([Id]), 
    CONSTRAINT [FK_Tickets_ToApplicationUserCloser] FOREIGN KEY ([CloserId]) REFERENCES [ApplicationUser](Id)
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK__Tickets__TicketStatusMaster] FOREIGN KEY([TicketStatusId])
REFERENCES [dbo].[TicketStatusMaster] ([TicketStatusId])
GO

ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK__Tickets__TicketStatusMaster]
GO


