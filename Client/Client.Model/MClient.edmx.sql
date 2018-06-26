
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2018 19:54:19
-- Generated from EDMX file: G:\迅雷下载\Client\Client.Model\MClient.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Client];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_OperatorMenuAuthority_Menu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperatorMenuAuthority] DROP CONSTRAINT [FK_OperatorMenuAuthority_Menu];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[Office]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Office];
GO
IF OBJECT_ID(N'[dbo].[Operator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operator];
GO
IF OBJECT_ID(N'[dbo].[OperatorMenuAuthority]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperatorMenuAuthority];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Operator'
CREATE TABLE [dbo].[Operator] (
    [Operatorid] varchar(8)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Roleid] varchar(10)  NOT NULL,
    [Userid] varchar(20)  NOT NULL,
    [OperatorName] varchar(100)  NULL,
    [CodeNo] varchar(20)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Userid] varchar(20)  NOT NULL,
    [UserName] varchar(100)  NULL,
    [CodeNo] varchar(6)  NULL,
    [SpellNo] varchar(6)  NULL,
    [CustomNo] varchar(6)  NULL,
    [StrokeNo] varchar(6)  NULL,
    [Sex] varchar(4)  NULL,
    [Birthday] datetime  NULL,
    [Nation] varchar(12)  NULL,
    [Diploma] varchar(16)  NULL,
    [Officeid] varchar(20)  NULL,
    [VestDept] varchar(16)  NULL,
    [Duty] varchar(16)  NULL,
    [Role] varchar(16)  NULL,
    [LaborageNo] varchar(10)  NULL,
    [ExamineMoney] decimal(18,2)  NULL,
    [RegisterLimitNo] int  NULL,
    [BespeakLimitNo] int  NULL,
    [PledgeMoney] decimal(18,2)  NULL,
    [Workkind] varchar(16)  NULL,
    [PrescriptionRight] int  NOT NULL,
    [ExamineName] varchar(20)  NULL,
    [StopFlag] int  NOT NULL,
    [StopOperator] varchar(20)  NULL,
    [StopDate] datetime  NULL,
    [Remark] varchar(500)  NULL,
    [TELEPHONE] varchar(20)  NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [Roleid] varchar(10)  NOT NULL,
    [Role1] varchar(30)  NOT NULL,
    [CodeNo] varchar(6)  NOT NULL,
    [SpellNo] varchar(6)  NULL,
    [CustomNo] varchar(6)  NULL,
    [StrokeNo] varchar(6)  NULL
);
GO

-- Creating table 'Office'
CREATE TABLE [dbo].[Office] (
    [Officeid] varchar(20)  NOT NULL,
    [Office1] varchar(20)  NOT NULL,
    [CodeNo] varchar(10)  NULL,
    [SpellNo] varchar(10)  NULL,
    [CustomNo] varchar(10)  NULL,
    [StrokeNo] varchar(10)  NULL,
    [Department] varchar(16)  NULL,
    [Parentid] int  NULL,
    [hasChild] int  NOT NULL,
    [BedAmount] int  NULL,
    [DiseaseArea] varchar(12)  NULL,
    [OfficeType] varchar(10)  NULL,
    [Workkind] varchar(10)  NULL,
    [LimitFund] int  NULL,
    [ServiceObject] varchar(40)  NULL,
    [Link] int  NULL,
    [OfficeAddress] varchar(50)  NULL,
    [Explanation] varchar(100)  NULL,
    [StopFlag] int  NOT NULL,
    [StopDate] datetime  NULL,
    [StopOperator] varchar(20)  NULL,
    [position] varchar(40)  NULL
);
GO

-- Creating table 'Menu'
CREATE TABLE [dbo].[Menu] (
    [Nodeid] varchar(50)  NOT NULL,
    [NodeName] varchar(100)  NULL,
    [ParentNode] varchar(50)  NULL,
    [isEndNode] varchar(2)  NULL,
    [Pluginid] varchar(100)  NULL,
    [Commentary] varchar(500)  NULL,
    [Disporder] varchar(20)  NULL,
    [type] int  NOT NULL,
    [image] varbinary(max)  NULL,
    [IsChoose] bit  NULL
);
GO

-- Creating table 'OperatorMenuAuthority'
CREATE TABLE [dbo].[OperatorMenuAuthority] (
    [Operatorid] varchar(8)  NOT NULL,
    [Privid] varchar(10)  NOT NULL,
    [Nodeid] varchar(50)  NOT NULL,
    [ParentNode] varchar(50)  NULL,
    [isEndNode] varchar(2)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Operatorid] in table 'Operator'
ALTER TABLE [dbo].[Operator]
ADD CONSTRAINT [PK_Operator]
    PRIMARY KEY CLUSTERED ([Operatorid] ASC);
GO

-- Creating primary key on [Userid] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Userid] ASC);
GO

-- Creating primary key on [Roleid] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([Roleid] ASC);
GO

-- Creating primary key on [Officeid] in table 'Office'
ALTER TABLE [dbo].[Office]
ADD CONSTRAINT [PK_Office]
    PRIMARY KEY CLUSTERED ([Officeid] ASC);
GO

-- Creating primary key on [Nodeid] in table 'Menu'
ALTER TABLE [dbo].[Menu]
ADD CONSTRAINT [PK_Menu]
    PRIMARY KEY CLUSTERED ([Nodeid] ASC);
GO

-- Creating primary key on [Operatorid], [Privid] in table 'OperatorMenuAuthority'
ALTER TABLE [dbo].[OperatorMenuAuthority]
ADD CONSTRAINT [PK_OperatorMenuAuthority]
    PRIMARY KEY CLUSTERED ([Operatorid], [Privid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Nodeid] in table 'OperatorMenuAuthority'
ALTER TABLE [dbo].[OperatorMenuAuthority]
ADD CONSTRAINT [FK_OperatorMenuAuthority_Menu]
    FOREIGN KEY ([Nodeid])
    REFERENCES [dbo].[Menu]
        ([Nodeid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatorMenuAuthority_Menu'
CREATE INDEX [IX_FK_OperatorMenuAuthority_Menu]
ON [dbo].[OperatorMenuAuthority]
    ([Nodeid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------