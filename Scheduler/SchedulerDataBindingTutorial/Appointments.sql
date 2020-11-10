USE [SchedulerData]
GO

/****** Object:  Table [dbo].[Appointments]    Script Date: 11/10/2020 2:51:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Summary] [nvarchar](255) NOT NULL,
	[Start] [datetime] NOT NULL,
	[End] [datetime] NOT NULL,
	[RecurrenceRule] [nvarchar](1024) NULL,
	[MasterEventId] [int] NULL,
	[Location] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[BackgroundId] [int] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF_Appointments_BackgroundId]  DEFAULT ((1)) FOR [BackgroundId]
GO


