
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/08/2019 18:24:27
-- Generated from EDMX file: C:\Users\DAM\source\repos\Grupo4\ProyectoWinForm\AccesoDatos\Model\BibliotecaContext.edmx
-- --------------------------------------------------

IF  NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ProyectoWinForm')
        BEGIN
            CREATE DATABASE ProyectoWinForm
        END;
GO
SET QUOTED_IDENTIFIER OFF;
GO
USE [ProyectoWinForm];
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

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [DNI] nvarchar(10)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellidos] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Poblacion] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [Provincia] nvarchar(max)  NOT NULL,
    [Telefono1] nvarchar(max)  NOT NULL,
    [Telefono2] nvarchar(max)  NULL,
    [InicioSesion] bit  NULL,
    [Salt] nvarchar(max)  NULL
);
GO

-- Creating table 'AutorSet'
CREATE TABLE [dbo].[AutorSet] (
    [AutorId] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellidos] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClasificacionSet'
CREATE TABLE [dbo].[ClasificacionSet] (
    [ClasificacionId] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GeneroSet'
CREATE TABLE [dbo].[GeneroSet] (
    [GeneroId] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EditorialSet'
CREATE TABLE [dbo].[EditorialSet] (
    [EditorialId] int IDENTITY(1,1) NOT NULL,
    [RazonSocial] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Poblacion] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [Provincia] nvarchar(max)  NOT NULL,
    [Telefono1] nvarchar(max)  NOT NULL,
    [Telefono2] nvarchar(max)  NULL,
    [PersonaContacto] nvarchar(max)  NULL,
    [Observaciones] nvarchar(max)  NULL
);
GO

-- Creating table 'LibroSet'
CREATE TABLE [dbo].[LibroSet] (
    [LibroId] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Descripción] nvarchar(max)  NOT NULL,
    [Stock] int  NULL,
    [StockDisponible] int  NULL,
    [Imagen] varbinary(max)  NULL,
    [AutorAutorId] int  NOT NULL,
    [ClasificacionClasificacionId] int  NOT NULL,
    [GeneroGeneroId] int  NOT NULL,
    [EditorialEditorialId] int  NOT NULL
);
GO

-- Creating table 'PrestamoSet'
CREATE TABLE [dbo].[PrestamoSet] (
    [PrestamoId] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NOT NULL,
    [FechaDevolucion] datetime  NULL,
    [UsuarioDNI] nvarchar(10)  NOT NULL,
    [LibroLibroId] int  NOT NULL
);
GO

-- Creating table 'ConfiguracionSet'
CREATE TABLE [dbo].[ConfiguracionSet] (
    [ConfiguracionId] int IDENTITY(1,1) NOT NULL,
    [NumDiasPrestamo1] int  NULL,
    [NumDiasPrestamo2] int  NULL,
    [MaxPrestamoUsuario] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DNI] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([DNI] ASC);
GO

-- Creating primary key on [AutorId] in table 'AutorSet'
ALTER TABLE [dbo].[AutorSet]
ADD CONSTRAINT [PK_AutorSet]
    PRIMARY KEY CLUSTERED ([AutorId] ASC);
GO

-- Creating primary key on [ClasificacionId] in table 'ClasificacionSet'
ALTER TABLE [dbo].[ClasificacionSet]
ADD CONSTRAINT [PK_ClasificacionSet]
    PRIMARY KEY CLUSTERED ([ClasificacionId] ASC);
GO

-- Creating primary key on [GeneroId] in table 'GeneroSet'
ALTER TABLE [dbo].[GeneroSet]
ADD CONSTRAINT [PK_GeneroSet]
    PRIMARY KEY CLUSTERED ([GeneroId] ASC);
GO

-- Creating primary key on [EditorialId] in table 'EditorialSet'
ALTER TABLE [dbo].[EditorialSet]
ADD CONSTRAINT [PK_EditorialSet]
    PRIMARY KEY CLUSTERED ([EditorialId] ASC);
GO

-- Creating primary key on [LibroId] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [PK_LibroSet]
    PRIMARY KEY CLUSTERED ([LibroId] ASC);
GO

-- Creating primary key on [PrestamoId] in table 'PrestamoSet'
ALTER TABLE [dbo].[PrestamoSet]
ADD CONSTRAINT [PK_PrestamoSet]
    PRIMARY KEY CLUSTERED ([PrestamoId] ASC);
GO

-- Creating primary key on [ConfiguracionId] in table 'ConfiguracionSet'
ALTER TABLE [dbo].[ConfiguracionSet]
ADD CONSTRAINT [PK_ConfiguracionSet]
    PRIMARY KEY CLUSTERED ([ConfiguracionId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AutorAutorId] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [FK_AutorLibro]
    FOREIGN KEY ([AutorAutorId])
    REFERENCES [dbo].[AutorSet]
        ([AutorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutorLibro'
CREATE INDEX [IX_FK_AutorLibro]
ON [dbo].[LibroSet]
    ([AutorAutorId]);
GO

-- Creating foreign key on [ClasificacionClasificacionId] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [FK_ClasificacionLibro]
    FOREIGN KEY ([ClasificacionClasificacionId])
    REFERENCES [dbo].[ClasificacionSet]
        ([ClasificacionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClasificacionLibro'
CREATE INDEX [IX_FK_ClasificacionLibro]
ON [dbo].[LibroSet]
    ([ClasificacionClasificacionId]);
GO

-- Creating foreign key on [GeneroGeneroId] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [FK_GeneroLibro]
    FOREIGN KEY ([GeneroGeneroId])
    REFERENCES [dbo].[GeneroSet]
        ([GeneroId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GeneroLibro'
CREATE INDEX [IX_FK_GeneroLibro]
ON [dbo].[LibroSet]
    ([GeneroGeneroId]);
GO

-- Creating foreign key on [EditorialEditorialId] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [FK_EditorialLibro]
    FOREIGN KEY ([EditorialEditorialId])
    REFERENCES [dbo].[EditorialSet]
        ([EditorialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EditorialLibro'
CREATE INDEX [IX_FK_EditorialLibro]
ON [dbo].[LibroSet]
    ([EditorialEditorialId]);
GO

-- Creating foreign key on [UsuarioDNI] in table 'PrestamoSet'
ALTER TABLE [dbo].[PrestamoSet]
ADD CONSTRAINT [FK_UsuarioPrestamo]
    FOREIGN KEY ([UsuarioDNI])
    REFERENCES [dbo].[UsuarioSet]
        ([DNI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPrestamo'
CREATE INDEX [IX_FK_UsuarioPrestamo]
ON [dbo].[PrestamoSet]
    ([UsuarioDNI]);
GO

-- Creating foreign key on [LibroLibroId] in table 'PrestamoSet'
ALTER TABLE [dbo].[PrestamoSet]
ADD CONSTRAINT [FK_LibroPrestamo]
    FOREIGN KEY ([LibroLibroId])
    REFERENCES [dbo].[LibroSet]
        ([LibroId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LibroPrestamo'
CREATE INDEX [IX_FK_LibroPrestamo]
ON [dbo].[PrestamoSet]
    ([LibroLibroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------