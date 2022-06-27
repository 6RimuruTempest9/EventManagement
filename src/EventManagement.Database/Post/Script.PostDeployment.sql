--- Countries
INSERT INTO [dbo].[Countries]
	(
		[dbo].[Countries].[Name]
	)
VALUES
	(N'Belarus'),
	(N'Russia'),
	(N'Ukraine'),
	(N'Australia'),
	(N'United States');
GO

--- Towns
INSERT INTO [dbo].[Towns]
	(
		[dbo].[Towns].[CountryId],
		[dbo].[Towns].[Name]
	)
VALUES
	(1, N'Gomel'),
	(2, N'Moscow'),
	(3, N'Kiev');
GO

--- Streets
INSERT INTO [dbo].[Streets]
	(
		[dbo].[Streets].[TownId],
		[dbo].[Streets].[Name]
	)
VALUES
	(1, N'Barykina Street'),
	(2, N'Mira Avenue'),
	(3, N'Adam Mickiewicz Street');
GO

--- Venues
INSERT INTO [dbo].[Venues]
	(
		[dbo].[Venues].[StreetId],
		[dbo].[Venues].[Description]
	)
VALUES
	(1, N'Belarus, Gomel, Barykina Street'),
	(2, N'Russia, Moscow, Mira Avenue'),
	(3, N'Ukraine, Kiev, Adam Mickiewicz Street');
GO

--- Organizers
INSERT INTO [dbo].[Organizers]
	(
		[dbo].[Organizers].[First Name],
		[dbo].[Organizers].[Last Name]
	)
VALUES
	(1, N'Vitali', N'Talatai'),
	(2, N'Dmitry', N'Lebeshkov'),
	(3, N'Andrey', N'Slepukhin');
GO

--- Speakers
INSERT INTO [dbo].[Speakers]
	(
		[dbo].[Speakers].[First Name],
		[dbo].[Speakers].[Last Name]
	)
VALUES
	(1, N'Vitali', N'Talatai'),
	(2, N'Alexandr', N'Pushkin'),
	(3, N'Vasily', N'Novikov');
GO

--- Events
INSERT INTO [dbo].[Events]
	(
		[dbo].[Events].[Name],
		[dbo].[Events].[Description],
		[dbo].[Events].[StartDate],
		[dbo].[Events].[EndDate],
		[dbo].[Events].[VenueId],
		[dbo].[Events].[OrganizerId],
		[dbo].[Events].[SpeakerId]
	)
VALUES
	(N'Event 1', N'Description of Event 1', CONVERT(datetime, '27-06-22 6:00:00 PM', 5), CONVERT(datetime, '27-06-22 9:00:00 PM', 5), 1, 1, 1),
	(N'Event 2', N'Description of Event 2', CONVERT(datetime, '27-07-22 5:00:00 PM', 5), CONVERT(datetime, '27-07-22 8:00:00 PM', 5), 2, 2, 2),
	(N'Event 3', N'Description of Event 3', CONVERT(datetime, '27-08-22 4:00:00 PM', 5), CONVERT(datetime, '27-08-22 7:00:00 PM', 5), 3, 3, 3);
GO