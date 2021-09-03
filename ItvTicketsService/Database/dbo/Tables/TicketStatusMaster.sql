
CREATE TABLE [dbo].[TicketStatusMaster](
	[TicketStatusId] [int] IDENTITY(1,1) NOT NULL,
	[TicketStatus] [varchar](20) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_TicketStatusMaster] PRIMARY KEY CLUSTERED 
(
	[TicketStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[TicketStatusMaster] ADD  CONSTRAINT [DF_TicketStatusMaster_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO


