USE [dbPIMS]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 28/7/2013 5:37:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID]  AS (case len([ID]) 
	when (1) then ('C'+'000000')+CONVERT([varchar],[ID],0) 
	when (2) then ('C'+'00000')+CONVERT([varchar],[ID],0)
	when (3) then ('C'+'0000')+CONVERT([varchar],[ID],0)
	when (4) then ('C'+'000')+CONVERT([varchar],[ID],0)
	when (5) then ('C'+'00')+CONVERT([varchar],[ID],0)
	when (6) then ('C'+'0')+CONVERT([varchar],[ID],0)	
	else 'C'+CONVERT([varchar],[ID],0) end) PERSISTED NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [CategoryID] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

