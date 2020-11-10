USE [SchedulerData]
GO

/****** Object:  Table [dbo].[AppointmentsResources]    Script Date: 11/10/2020 2:51:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AppointmentsResources](
	[AppointmentID] [int] NOT NULL,
	[ResourceID] [int] NOT NULL,
 CONSTRAINT [PK_AppointmentsResources] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC,
	[ResourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AppointmentsResources]  WITH CHECK ADD  CONSTRAINT [AppointmentsResources_Appointments] FOREIGN KEY([AppointmentID])
REFERENCES [dbo].[Appointments] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AppointmentsResources] CHECK CONSTRAINT [AppointmentsResources_Appointments]
GO

ALTER TABLE [dbo].[AppointmentsResources]  WITH CHECK ADD  CONSTRAINT [AppointmentsResources_Resources] FOREIGN KEY([ResourceID])
REFERENCES [dbo].[Resources] ([ID])
GO

ALTER TABLE [dbo].[AppointmentsResources] CHECK CONSTRAINT [AppointmentsResources_Resources]
GO


