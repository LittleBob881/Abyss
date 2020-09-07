CREATE TABLE [dbo].[RoomItem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [image] NCHAR(15) NULL, 
    [Discription] NCHAR(30) NULL, 
    [inventoryItemID] INT NULL, 
    CONSTRAINT [FK_RoomItem_IIinRI] FOREIGN KEY (inventoryItemID) REFERENCES [InventoryItems]([Id]), 
    
    
)
