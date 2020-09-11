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
:setvar DefaultDataPath "C:\Users\Judith Kearney\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Judith Kearney\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
PRINT N'Creating [dbo].[FK_Table1_Room]...';


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH NOCHECK
    ADD CONSTRAINT [FK_Table1_Room] FOREIGN KEY ([Room]) REFERENCES [dbo].[Room] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Table1_RoomItem]...';


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH NOCHECK
    ADD CONSTRAINT [FK_Table1_RoomItem] FOREIGN KEY ([RoomItemID]) REFERENCES [dbo].[RoomItem] ([Id]);


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

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[RoomRoomItems] WITH CHECK CHECK CONSTRAINT [FK_Table1_Room];

ALTER TABLE [dbo].[RoomRoomItems] WITH CHECK CHECK CONSTRAINT [FK_Table1_RoomItem];


GO
PRINT N'Update complete.';


GO
