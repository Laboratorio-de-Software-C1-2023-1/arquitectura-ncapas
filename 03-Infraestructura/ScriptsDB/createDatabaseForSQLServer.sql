USE [arquitecturaNCapas]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 23/5/2023 20:41:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [uniqueidentifier] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[edad] [int] NOT NULL
) ON [PRIMARY]
GO
