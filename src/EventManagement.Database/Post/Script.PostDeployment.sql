--- Events
INSERT INTO [dbo].[Events]
	(
		[dbo].[Events].[Name],
		[dbo].[Events].[Description],
		[dbo].[Events].[StartDate],
		[dbo].[Events].[EndDate],
		[dbo].[Events].[Venue],
		[dbo].[Events].[Organizer],
		[dbo].[Events].[Speaker]
	)
VALUES
	(N'Event 1', N'Description of Event 1', CONVERT(datetime, '27-06-22 6:00:00 PM', 5), CONVERT(datetime, '27-06-22 9:00:00 PM', 5), N'Venue 1', N'EPAM Systems', N'Talatai Vitali'),
	(N'Event 2', N'Description of Event 2', CONVERT(datetime, '27-07-22 5:00:00 PM', 5), CONVERT(datetime, '27-07-22 8:00:00 PM', 5), N'Venue 2', N'Modsen'      , N'Talatai Vitali'),
	(N'Event 3', N'Description of Event 3', CONVERT(datetime, '27-08-22 4:00:00 PM', 5), CONVERT(datetime, '27-08-22 7:00:00 PM', 5), N'Venue 3', N'ITechArt'    , N'Talatai Vitali');
GO