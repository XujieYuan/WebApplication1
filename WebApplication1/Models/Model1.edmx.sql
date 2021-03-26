
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/26/2021 11:18:05
-- Generated from EDMX file: C:\Users\Administrator\source\repos\WebApplication1\WebApplication1\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_House_categeryTip]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tips] DROP CONSTRAINT [FK_House_categeryTip];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[House_categery]', 'U') IS NOT NULL
    DROP TABLE [dbo].[House_categery];
GO
IF OBJECT_ID(N'[dbo].[Tips]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tips];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'House_categery'
CREATE TABLE [dbo].[House_categery] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'Tips'
CREATE TABLE [dbo].[Tips] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Img_src] nvarchar(max)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [House_categeryId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'House_categery'
ALTER TABLE [dbo].[House_categery]
ADD CONSTRAINT [PK_House_categery]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [PK_Tips]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [House_categeryId] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [FK_House_categeryTip]
    FOREIGN KEY ([House_categeryId])
    REFERENCES [dbo].[House_categery]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_House_categeryTip'
CREATE INDEX [IX_FK_House_categeryTip]
ON [dbo].[Tips]
    ([House_categeryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------