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
	idSysExp			int				not null  identity(1,1),
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
	idPlatform			int				not null	identity(1,1),
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
	idPlatform			int 			not null,
	primary key(idJeu,idPlatform)
);

go
PRINT('Création tblJeu')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblJeu') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblJeu
CREATE TABLE tblJeu
(
	idJeu 				int				not null 	identity(1,1),
	developpeur			varchar(100)	not null,
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
	idTheme				int				not null	identity(1,1),
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
	idGenre				int				not null	identity(1,1),
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
	idClassification 	int				not null	identity(1,1),
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
	primary key(idJeu,idTheme)
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
	primary key(idGenre,idJeu)
);



go
PRINT('Création tblRole')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblRole') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblRole
CREATE TABLE tblRole
(
	idRole				int				not null	identity(1,1),
	nom					varchar(60)		not null,
	description			varchar(250)	not null,
	tag					varchar			null,
	constraint PK_tblRole_idRole PRIMARY KEY(idRole)
);


go
PRINT('Création tblEmploye')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblEmploye') IS NOT NULL
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

go
PRINT('Création tblEmployeEquipe')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblEmployeEquipe') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblEmployeEquipe
CREATE TABLE tblEmployeEquipe
	matricule			char(7)			not null,
	idEquipe			int				not null,
	primary key(matricule,idEquipe)
);

go
PRINT('Création tblEquipe')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblEquipe') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblEquipe
CREATE TABLE tblEquipe
	
	idEquipe			int				not null   	identity(1,1), 
	nom 				varchar(40)		not null,
	tag					varchar			null,
	constraint PK_tblEquipe_idEquipe PRIMARY KEY(idEquipe)
);

go
PRINT('Création tblProjet')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblProjet') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblProjet
CREATE TABLE tblProjet
	
	idProjet			int				not null	identity(1,1),
	nom					varchar(50)		not null,
	description			varchar(150)	not null,
	idJeu				int				not null,
	tag					varchar			null,
	constraint PK_tblProjet_idProjet PRIMARY KEY(idProjet)
);


go
PRINT('Création tblCategorieTest')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblCategorieTest') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblCategorieTest
CREATE TABLE tblCategorieTest
	
	idCategorieTest		int				not null	identity(1,1),
	nom					varchar(50)		not null,
	description			varchar(150)	not null,
	tag					varchar			null,
	constraint PK_tblCategorieTest_idCategorieTest PRIMARY KEY(idCategorieTest)
);

go
PRINT('Création tblTest')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblTest') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblTest
CREATE TABLE tblTest
	
	idTest				int				not null	identity(1,1),
	resultat			double      	not null,
	description			varchar(150)	not null,
	idCategorieTest		int				not null,
	tag					varchar			null,
	constraint PK_tblTest_idTest PRIMARY KEY(idTest)
);

go
PRINT('Création tblTravail')
-- -------------------------------------------------------
go

IF OBJECT_ID('bdTexelFredAlex.dbo.tblTravail') IS NOT NULL
DROP TABLE bdTexelFredAlex.dbo.tblTravail
CREATE TABLE tblTravail
	
	idTest				int				not null,
	idEquipe			int				not null,
	idProjet			int				not null,
	
	primary key (idTest,idEquipe,idProjet)
);







