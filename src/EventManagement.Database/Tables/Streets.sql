CREATE TABLE [dbo].[Streets]
(
	[Id]     INT          PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[TownId] INT          CHECK([TownId] > 0) NOT NULL,
	[Name]   NVARCHAR(32) CHECK([Name] != N'') NOT NULL,
)