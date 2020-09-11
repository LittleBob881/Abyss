CREATE TABLE [dbo].[RoomRoomItems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RoomID] INT NOT NULL, 
    [RoomItemID] INT NOT NULL, 
    CONSTRAINT [FK_RRI_Room] FOREIGN KEY ([RoomID]) REFERENCES [Room]([Id]), 
    CONSTRAINT [FK_RRI_RoomItem] FOREIGN KEY ([RoomItemID]) REFERENCES [RoomItem] ([Id])
)
