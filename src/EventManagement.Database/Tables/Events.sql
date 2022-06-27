CREATE TABLE [dbo].[Events]
(
	[Id]          INT            PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	[Name]        NVARCHAR(64)   CHECK([Name] != N'') NOT NULL,
	[Description] NVARCHAR(1024) CHECK([Description] != N'') NOT NULL,
	[OrganizerId] INT            CHECK([OrganizerId] > 0) NOT NULL,
	[SpeakerId]   INT            CHECK([SpeakerId] > 0) NOT NULL,
	[StartDate]   DATETIME       NOT NULL,
	[EndDate]     DATETIME       NOT NULL,
	[VenueId]     INT            CHECK([VenueId] > 0) NOT NULL,
)