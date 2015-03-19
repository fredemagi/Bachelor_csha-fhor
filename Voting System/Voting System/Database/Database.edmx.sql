
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2015 13:43:54
-- Generated from EDMX file: C:\Users\SATLP850132\Desktop\SEM6\BACHELOR_PROJ\Bachelor_csha-fhor\Bachelor_csha-fhor\Voting System\Voting System\Database\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VotingDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Association]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet] DROP CONSTRAINT [FK_Association];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[VotingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VotingSet];
GO
IF OBJECT_ID(N'[dbo].[PartySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartySet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VotingSet'
CREATE TABLE [dbo].[VotingSet] (
    [CPR] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'PartySet'
CREATE TABLE [dbo].[PartySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Votes] int  NOT NULL,
    [Letter] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Votes] int  NOT NULL,
    [Party_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CPR] in table 'VotingSet'
ALTER TABLE [dbo].[VotingSet]
ADD CONSTRAINT [PK_VotingSet]
    PRIMARY KEY CLUSTERED ([CPR] ASC);
GO

-- Creating primary key on [Id] in table 'PartySet'
ALTER TABLE [dbo].[PartySet]
ADD CONSTRAINT [PK_PartySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Party_Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_Association]
    FOREIGN KEY ([Party_Id])
    REFERENCES [dbo].[PartySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Association'
CREATE INDEX [IX_FK_Association]
ON [dbo].[PersonSet]
    ([Party_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------