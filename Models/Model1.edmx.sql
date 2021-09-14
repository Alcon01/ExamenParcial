
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/14/2021 13:50:03
-- Generated from EDMX file: C:\Users\Windows\source\repos\ExamenParcial\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MDFEXAMEN];
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

-- Creating table 'GastosSet'
CREATE TABLE [dbo].[GastosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Cantidad] nvarchar(max)  NOT NULL,
    [CategoriaId] int  NOT NULL,
    [MonedaId] int  NOT NULL,
    [LugarId] int  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MonedaSet'
CREATE TABLE [dbo].[MonedaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LugarSet'
CREATE TABLE [dbo].[LugarSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GastosSet'
ALTER TABLE [dbo].[GastosSet]
ADD CONSTRAINT [PK_GastosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MonedaSet'
ALTER TABLE [dbo].[MonedaSet]
ADD CONSTRAINT [PK_MonedaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LugarSet'
ALTER TABLE [dbo].[LugarSet]
ADD CONSTRAINT [PK_LugarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoriaId] in table 'GastosSet'
ALTER TABLE [dbo].[GastosSet]
ADD CONSTRAINT [FK_CategoriaGastos]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaGastos'
CREATE INDEX [IX_FK_CategoriaGastos]
ON [dbo].[GastosSet]
    ([CategoriaId]);
GO

-- Creating foreign key on [MonedaId] in table 'GastosSet'
ALTER TABLE [dbo].[GastosSet]
ADD CONSTRAINT [FK_MonedaGastos]
    FOREIGN KEY ([MonedaId])
    REFERENCES [dbo].[MonedaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MonedaGastos'
CREATE INDEX [IX_FK_MonedaGastos]
ON [dbo].[GastosSet]
    ([MonedaId]);
GO

-- Creating foreign key on [LugarId] in table 'GastosSet'
ALTER TABLE [dbo].[GastosSet]
ADD CONSTRAINT [FK_LugarGastos]
    FOREIGN KEY ([LugarId])
    REFERENCES [dbo].[LugarSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LugarGastos'
CREATE INDEX [IX_FK_LugarGastos]
ON [dbo].[GastosSet]
    ([LugarId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------