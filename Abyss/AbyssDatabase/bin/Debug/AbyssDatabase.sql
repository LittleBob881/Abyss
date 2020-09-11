﻿/*
Deployment script for AbyssDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "AbyssDatabase"
:setvar DefaultFilePrefix "AbyssDatabase"
:setvar DefaultDataPath "C:\Users\Judith Kearney\AppData\Local\Microsoft\VisualStudio\SSDT\AbyssDatabase"
:setvar DefaultLogPath "C:\Users\Judith Kearney\AppData\Local\Microsoft\VisualStudio\SSDT\AbyssDatabase"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key fa2bc8b1-d370-4794-afac-4cac383fabfb is skipped, element [dbo].[RoomItem].[IdRI] (SqlSimpleColumn) will not be renamed to Id';


GO
PRINT N'Rename refactoring operation with key 3886827d-79c9-4e40-960c-3c9705612d03 is skipped, element [dbo].[Room].[IdR] (SqlSimpleColumn) will not be renamed to Id';


GO
PRINT N'Rename refactoring operation with key 84414774-4f7f-4c61-8295-2b5df181bac8 is skipped, element [dbo].[RoomRoomItems].[IdRRI] (SqlSimpleColumn) will not be renamed to Id';


GO
PRINT N'Rename refactoring operation with key 96c8f159-903b-4a45-867e-115ccf1f6543 is skipped, element [dbo].[RoomRoomItems].[Room] (SqlSimpleColumn) will not be renamed to RoomID';


GO
PRINT N'Creating [dbo].[FK_RRI_Room]...';


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH NOCHECK
    ADD CONSTRAINT [FK_RRI_Room] FOREIGN KEY ([RoomID]) REFERENCES [dbo].[Room] ([Id]);


GO
PRINT N'Creating [dbo].[FK_RRI_RoomItem]...';


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH NOCHECK
    ADD CONSTRAINT [FK_RRI_RoomItem] FOREIGN KEY ([RoomItemID]) REFERENCES [dbo].[RoomItem] ([Id]);


GO
PRINT N'Creating [dbo].[getItems]...';


GO
CREATE VIEW [dbo].[getItems]
	AS SELECT * FROM [InventoryItems];
GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'fa2bc8b1-d370-4794-afac-4cac383fabfb')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('fa2bc8b1-d370-4794-afac-4cac383fabfb')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '3886827d-79c9-4e40-960c-3c9705612d03')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('3886827d-79c9-4e40-960c-3c9705612d03')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '84414774-4f7f-4c61-8295-2b5df181bac8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('84414774-4f7f-4c61-8295-2b5df181bac8')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '96c8f159-903b-4a45-867e-115ccf1f6543')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('96c8f159-903b-4a45-867e-115ccf1f6543')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a783b895-e9e6-45ef-9d71-261520ea9ddb')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a783b895-e9e6-45ef-9d71-261520ea9ddb')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '67cff58b-0ef3-4663-82e2-775a870efe4e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('67cff58b-0ef3-4663-82e2-775a870efe4e')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH CHECK CHECK CONSTRAINT [FK_RRI_Room];

ALTER TABLE [dbo].[RoomRoomItems] WITH CHECK CHECK CONSTRAINT [FK_RRI_RoomItem];


GO
PRINT N'Update complete.';


GO
