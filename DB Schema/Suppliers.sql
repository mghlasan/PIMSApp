USE [dbPIMS]
GO

/****** Object:  Table [dbo].[Suppliers]    Script Date: 28/7/2013 5:18:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID]  AS (case len([ID]) 
	when (1) then ('S'+'000000')+CONVERT([varchar] (20),[ID],0) 
	when (2) then ('S'+'00000')+CONVERT([varchar] (20),[ID],0)
	when (3) then ('S'+'0000')+CONVERT([varchar] (20),[ID],0)
	when (4) then ('S'+'000')+CONVERT([varchar] (20),[ID],0)
	when (5) then ('S'+'00')+CONVERT([varchar] (20),[ID],0)
	when (6) then ('S'+'0')+CONVERT([varchar] (20),[ID],0)	
	else 'S'+CONVERT([varchar] (20),[ID],0) end) PERSISTED NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[CreditDue] [money] NULL,
	[Phone] [nvarchar](20) NULL,
	[Address] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [SupplierID] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

