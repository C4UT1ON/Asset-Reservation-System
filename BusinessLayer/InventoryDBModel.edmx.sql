
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2018 00:57:53
-- Generated from EDMX file: C:\Users\Rick\source\repos\InventoryFinal\BusinessLayer\InventoryDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Inventorydb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Reservations_Assets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_Reservations_Assets];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Assets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assets];
GO
IF OBJECT_ID(N'[dbo].[Reservations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservations];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Assets'
CREATE TABLE [dbo].[Assets] (
    [Asset_id] nvarchar(50)  NOT NULL,
    [Asset_name] nvarchar(max)  NOT NULL,
    [asset_type] nvarchar(max)  NOT NULL,
    [asset_status] nvarchar(max)  NOT NULL,
    [Asset_description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [Reservation_id] int IDENTITY(1,1)  NOT NULL,
    [Reservation_start] datetime  NOT NULL,
    [Reservation_end] datetime  NOT NULL,
    [Asset_AssetId] nvarchar(50)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [User_id] int IDENTITY(1,1) NOT NULL,
    [User_username] varchar(50)  NOT NULL,
    [User_firstname] varchar(50)  NOT NULL,
    [User_lastname] varchar(50)  NOT NULL,
    [User_password] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Asset_id] in table 'Assets'
ALTER TABLE [dbo].[Assets]
ADD CONSTRAINT [PK_Assets]
    PRIMARY KEY CLUSTERED ([Asset_id] ASC);
GO

-- Creating primary key on [Reservation_id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
    PRIMARY KEY CLUSTERED ([Reservation_id] ASC);
GO

-- Creating primary key on [User_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([User_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Asset_AssetId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_Reservations_Assets]
    FOREIGN KEY ([Asset_AssetId])
    REFERENCES [dbo].[Assets]
        ([Asset_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservations_Assets'
CREATE INDEX [IX_FK_Reservations_Assets]
ON [dbo].[Reservations]
    ([Asset_AssetId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------