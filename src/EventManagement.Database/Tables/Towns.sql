CREATE TABLE [dbo].[Towns]
(
	[Id]        INT          PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[CountryId] INT          CHECK([CountryId] > 0) NOT NULL,
	[Name]      NVARCHAR(32) CHECK([Name] != N'') NOT NULL,
)