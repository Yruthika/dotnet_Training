USE [DBInteraction]
GO
/****** Object:  StoredProcedure [dbo].[PersonList]    Script Date: 22-06-2021 21:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PersonList]
     @ID INT
AS
BEGIN
	SELECT * FROM [dbo].[Person]
	   WHERE @ID=ID
END
