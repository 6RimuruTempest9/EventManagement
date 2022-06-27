CREATE TABLE [dbo].[Venues]
(
	[Id]          INT           PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[StreetId]    INT           CHECK([StreetId] > 0) NOT NULL,
	[Description] NVARCHAR(256) CHECK([Description] != N'') NOT NULL,
)