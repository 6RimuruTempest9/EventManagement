ALTER TABLE [dbo].[Events]
	ADD CONSTRAINT [FK_Events_Organizers]
	FOREIGN KEY ([OrganizerId])
	REFERENCES [dbo].[Organizers] ([Id])
	ON UPDATE CASCADE
	ON DELETE CASCADE