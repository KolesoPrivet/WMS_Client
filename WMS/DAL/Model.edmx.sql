
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/27/2016 11:55:28
-- Generated from EDMX file: C:\Users\Александр\Desktop\Учеба\Бакалавриат\Диплом\WMS\WMS\DAL\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GeneralDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Values_Sensors]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SValues] DROP CONSTRAINT [FK_Values_Sensors];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Sensors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sensors];
GO
IF OBJECT_ID(N'[dbo].[SValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SValues];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sensors'
CREATE TABLE [dbo].[Sensors] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Type] varchar(50)  NOT NULL,
    [LAT] float  NULL,
    [LNG] float  NULL,
    [Radius] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Values'
CREATE TABLE [dbo].[Values] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SensorID] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Time] time  NOT NULL,
    [Value] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Sensors'
ALTER TABLE [dbo].[Sensors]
ADD CONSTRAINT [PK_Sensors]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Values'
ALTER TABLE [dbo].[Values]
ADD CONSTRAINT [PK_Values]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SensorID] in table 'Values'
ALTER TABLE [dbo].[Values]
ADD CONSTRAINT [FK_Values_Sensors]
    FOREIGN KEY ([SensorID])
    REFERENCES [dbo].[Sensors]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Values_Sensors'
CREATE INDEX [IX_FK_Values_Sensors]
ON [dbo].[Values]
    ([SensorID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------