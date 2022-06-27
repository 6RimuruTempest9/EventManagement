ALTER TABLE [dbo].[Towns]
	ADD CONSTRAINT [FK_Countries_Towns]
	FOREIGN KEY ([CountryId])
	REFERENCES [dbo].[Countries] ([Id])
	ON UPDATE CASCADE
	ON DELETE CASCADE