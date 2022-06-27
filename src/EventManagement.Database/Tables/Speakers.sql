CREATE TABLE [dbo].[Speakers]
(
	[Id]         INT          PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[First Name] NVARCHAR(32) CHECK([First Name] != N'') NOT NULL,
	[Last Name]  NVARCHAR(32) CHECK([Last Name] != N'') NOT NULL,
)