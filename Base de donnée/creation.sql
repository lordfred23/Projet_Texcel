PRINT('Debut du script de création de la bd')
-- -------------------------------------------------------
GO
SET nocount    ON;
SET DATEFORMAT ymd;
USE master
GO
PRINT('Création de la base de donnée bdTexelFredAlex')
-- -------------------------------------------------------
IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'bdTexelFredAlex')
DROP DATABASE bdTexelFredAlex
GO

CREATE DATABASE bdTexelFredAlex ON PRIMARY
(NAME = 'bdTexelFredAlex',
FILENAME='C:\BD\bdTexelFredAlex.mdf',
SIZE =10MB , MAXSIZE = UNLIMITED,FILEGROWTH = 1MB )
LOG ON
( NAME ='bdTexelFredAlex_log',
FILENAME='C:\BD\bdTexelFredAlex_log.ldf',
SIZE =5MB ,MAXSIZE =25MB ,FILEGROWTH =10% )
GO


USE bdTexelFredAlex
go
PRINT('Création tblSystemExploitation')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblSystemExploitation') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblSystemExploitation
CREATE TABLE tblSystemExploitation
(
	idSysExp			int				not null  identity(1),
	nom 				varchar(100)	not null,
	version 			varchar(100)	not null,
	edition 			varchar(100)	null,
	tag					varchar			null,
	constraint PK_tblSystemExploitation_idSysExp PRIMARY KEY(idSysExp)
);

go
PRINT('Création tblPlatform')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblPlatform') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblPlatform
CREATE TABLE tblPlatform
(
	idPlatform			int				not null	identity(1),
	nom					varchar(100)	not null,
	config				varchar(250)	not null,
	typePlatform 		varchar(50)		not null,
	idSysExp			int				not null,
	tag					varchar			null,
	
	constraint PK_tblPlatform_idPlatform PRIMARY KEY(idPlatform)
);

go
PRINT('Création tblPlatformJeu')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblPlatformJeu') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblPlatformJeu
CREATE TABLE tblPlatformJeu
(
	idJeu				int				not null,
	idPlatform			int 			not null	
);

go
PRINT('Création tblJeu')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblJeu') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblJeu
CREATE TABLE tblJeu
(
	idJeu 				int				not null 	identity(1),
	developppeur		varchar(100)	not null,
	description			varchar(250)	not null,
	minimalConfig		varchar(250)	null,
	idClassification	int				not null,
	idJeu1				int				not null,
	tag					varchar			null,
	
	constraint PK_tblJeu_idJeu PRIMARY KEY(idJeu)
);


go
PRINT('Création tblTheme')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblTheme') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblTheme
CREATE TABLE tblTheme
(
	idTheme				int				not null	identity(1),
	nom					varchar(60)		not null,
	description			varchar(150)	null,
	tag					varchar			null,
	
	constraint PK_tblTheme_idTheme PRIMARY KEY(idTheme)
);


go
PRINT('Création tblGenre')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblGenre') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblGenre
CREATE TABLE tblGenre
(
	idGenre				int				not null	identity(1),
	nom					varchar(60)		not null,
	description			varchar(150)	null,
	tag					varchar			null,
	
	constraint PK_tblGenre_idGenre PRIMARY KEY(idGenre)
);

go
PRINT('Création tblClassification')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblClassification') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblClassification
CREATE TABLE tblClassification
(
	idClassification 	int				not null	identity(1),
	nom					varchar(60)		not null,
	description			varchar(150)	null,
	tag					varchar			null,
	
	constraint PK_tblClassification_idClassification PRIMARY KEY(idClassification)
);

go
PRINT('Création tblJeuTheme')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblJeuTheme') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblJeuTheme
CREATE TABLE tblJeuTheme
(
	idTheme				int				not null,
	idJeu				int				not null,
);

go
PRINT('Création tblGenreJeu')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblGenreJeu') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblGenreJeu
CREATE TABLE tblGenreJeu
(
	idGenre				int				not null,
	idJeu				int				not null,
);


go
PRINT('Création tblProjet')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblProjet') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblProjet
CREATE TABLE tblProjet
(
	idProjet 			int				not null	identity(1),
	description			varchar(250)	not null,
	idJeu				varchar()		not null,
	tag					varchar			null,
	
	constraint PK_tblProjet_idProjet PRIMARY KEY(idProjet)
);


go
PRINT('Création tblRole')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblRole') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblRole
CREATE TABLE tblRole
(
	idRole				int				not null	identity(1),
	nom					varchar(60)		not null,
	description			varchar(250)	not null,
	tag					varchar			null,
	
	constraint PK_tblRole_idRole PRIMARY KEY(idRole)
);


go
PRINT('Création tblEmploye')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.Employe') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblEmploye
CREATE TABLE tblEmploye
(
	matricule			char(7)			not null,
	nom					varchar(60)		not null,
	prenom				varchar(60)		not null,
	dateNaissance       varchar(50)		not null,
	adresse				varchar(150)	not null,
	noTelephone			char(7)			not null,
	posteTelephone		char (3)		not null,
	noTelephoneMaison	char(9)			not null,
	idRole				int				not null,
	
	tag					varchar			null,
	
	constraint PK_tblEmploye_matricule PRIMARY KEY(matricule)
);







