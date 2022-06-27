ALTER TABLE [dbo].[Events]
	ADD CONSTRAINT [FK_Events_Speakers]
	FOREIGN KEY ([SpeakerId])
	REFERENCES [dbo].[Speakers] ([Id])
	ON UPDATE CASCADE
	ON DELETE CASCADE