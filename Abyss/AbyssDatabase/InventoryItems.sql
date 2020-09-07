CREATE TABLE [dbo].[InventoryItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Image] NCHAR(15) NOT NULL, 
    [ActiveImage] NCHAR(15) NOT NULL
)
