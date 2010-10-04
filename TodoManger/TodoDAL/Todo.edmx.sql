
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/03/2010 02:35:59
-- Generated from EDMX file: D:\Learning\TodoManager\TodoManger_Net\TodoManger\TodoDAL\Todo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TodoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [details] nvarchar(max)  NOT NULL,
    [TaskGroupId] int  NOT NULL,
    [clientId] int  NOT NULL,
    [DatePosted] datetime  NOT NULL
);
GO

-- Creating table 'TaskGroups'
CREATE TABLE [dbo].[TaskGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DatePosted] datetime  NOT NULL
);
GO

-- Creating table 'clients'
CREATE TABLE [dbo].[clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [pic] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TaskGroups'
ALTER TABLE [dbo].[TaskGroups]
ADD CONSTRAINT [PK_TaskGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'clients'
ALTER TABLE [dbo].[clients]
ADD CONSTRAINT [PK_clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TaskGroupId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_TaskGroupTask]
    FOREIGN KEY ([TaskGroupId])
    REFERENCES [dbo].[TaskGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TaskGroupTask'
CREATE INDEX [IX_FK_TaskGroupTask]
ON [dbo].[Tasks]
    ([TaskGroupId]);
GO

-- Creating foreign key on [clientId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_clientTask]
    FOREIGN KEY ([clientId])
    REFERENCES [dbo].[clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_clientTask'
CREATE INDEX [IX_FK_clientTask]
ON [dbo].[Tasks]
    ([clientId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------