USE [dbPIMS]
GO

/****** Object:  Table [dbo].[Items]    Script Date: 28/7/2013 6:41:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ARITHABORT ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID]  AS (case len([ID]) when (1) then ('I'+'000000')+CONVERT([varchar](20),[ID],(0)) when (2) then ('I'+'00000')+CONVERT([varchar](20),[ID],(0)) when (3) then ('I'+'0000')+CONVERT([varchar](20),[ID],(0)) when (4) then ('I'+'000')+CONVERT([varchar](20),[ID],(0)) when (5) then ('I'+'00')+CONVERT([varchar](20),[ID],(0)) when (6) then ('I'+'0')+CONVERT([varchar](20),[ID],(0)) else 'I'+CONVERT([varchar](20),[ID],(0)) end) PERSISTED NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Stock] [int] NULL,
	[CategoryID] [varchar](20) NULL,
	[SupplierID] [varchar](20) NULL,
	[ImagePath] [nvarchar](200) NULL,
	[Status] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdatedDate] [datetime] NULL,
 CONSTRAINT [ItemID] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO

ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories]
GO

ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO

ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Items]
GO

ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Suppliers] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO

ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Suppliers]
GO


