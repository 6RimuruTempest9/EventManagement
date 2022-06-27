CREATE TABLE [dbo].[Countries]
(
	[Id]   INT          PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[Name] NVARCHAR(32) CHECK([Name] != N'') NOT NULL,
)