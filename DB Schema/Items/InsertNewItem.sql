USE [dbPIMS]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNewItems]    Script Date: 28/7/2013 9:24:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Chi Thra Rekha
-- Create date: 09-April-2013
-- Description:	Insert New Item(s)
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertNewItem]
	-- Add the parameters for the stored procedure here
	
	@ItemName nvarchar(50)  ,
	
	@Stock int,
	@CategoryID varchar(20),
	@SupplierID varchar(20) ,
	@ImagePath [nvarchar](200),
	@Status [nvarchar](50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Items
	(ItemName,  Stock, CategoryID,SupplierID,ImagePath,Status,CreatedDate)
	VALUES(@ItemName,@Stock,@CategoryID,@SupplierID,@ImagePath,@Status,GETDATE())
END

