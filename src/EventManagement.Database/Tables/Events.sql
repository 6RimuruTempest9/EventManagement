CREATE TABLE [dbo].[Events]
(
	[Id]          INT            PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[Name]        NVARCHAR(64)   CHECK([Name] != N'') NOT NULL,
	[Description] NVARCHAR(1024) CHECK([Description] != N'') NOT NULL,
	[Organizer]   NVARCHAR(256)  CHECK([Organizer] != N'') NOT NULL,
	[Speaker]     NVARCHAR(256)  CHECK([Speaker] != N'') NOT NULL,
	[StartDate]   DATETIME       NOT NULL,
	[EndDate]     DATETIME       NOT NULL,
	[Venue]       NVARCHAR(512)  CHECK([Venue] != N'') NOT NULL,
)