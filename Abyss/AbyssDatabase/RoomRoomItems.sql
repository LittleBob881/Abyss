CREATE TABLE [dbo].[RoomRoomItems]
(
	[IdRRI] INT NOT NULL PRIMARY KEY, 
    [Room] INT NOT NULL, 
    [RoomItemID] INT NOT NULL, 
    CONSTRAINT [FK_Table1_Room] FOREIGN KEY (Room) REFERENCES [Room]([Id]), 
    CONSTRAINT [FK_Table1_RoomItem] FOREIGN KEY (RoomItemID) REFERENCES [RoomItem] ([Id])
)
