USE [DBInteraction]
GO
/****** Object:  StoredProcedure [dbo].[PersonDelete]    Script Date: 22-06-2021 21:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PersonDelete]
       @ID INT
AS
BEGIN
   DELETE [dbo].[Person]
   WHERE ID=@ID
END
