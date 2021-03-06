USE [DBInteraction]
GO
/****** Object:  StoredProcedure [dbo].[PersonSave]    Script Date: 22-06-2021 21:46:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PersonSave]
     @FirstName          NVARCHAR(30)
     ,		@LastName     NVARCHAR(30)
     ,		@DateOfBirth  DATE
     ,		@Email		  NVARCHAR(20)
     ,		@Place		  NVARCHAR(20)
     ,		@PhoneNumber  NVARCHAR(30)
AS
BEGIN
	INSERT INTO [dbo].[Person]
	(
		[FirstName]
		,	[LastName]
		,	[DateOfBirth]
		,	[Email]
		,	[Place]
		,	[PhoneNumber]
	)
	VALUES
	(
		 @FirstName
		 ,	@LastName
		 ,	@DateOfBirth
		 ,	@Email
		 ,	@Place
		 ,	@PhoneNumber
	)


END
