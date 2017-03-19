
CREATE TRIGGER TR_SystemExploitation
on tblSystemExploitation
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @version AS VARCHAR(1000)
	DECLARE @edition as VARCHAR(1000)
	

	DECLARE cInserted CURSOR FOR
			SELECT  idSysExp,nom,version,edition FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@version,@edition;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblSystemExploitation
		SET tag=@nom+','+@version+','+@edition
		WHERE idSysExp=@id
		FETCH cInserted INTO @id,@nom,@version,@edition;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Platform
on tblPlatform
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @config AS VARCHAR(1000)
	DECLARE @type as VARCHAR(1000)
	

	DECLARE cInserted CURSOR FOR
			SELECT  idPlatform,nom,config,typePlatform FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@config,@type;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblPlatform
		SET tag=@nom+','+@config+','+@type
		WHERE idPlatform=@id
		FETCH cInserted INTO @id,@nom,@config,@type;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Jeu
on tblJeu
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @config AS VARCHAR(1000)
	DECLARE @dev as VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idJeu,nom,minimalConfig,developpeur,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@config,@dev,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblJeu
		SET tag=@nom+','+@config+','+@dev+','+@descr
		WHERE idJeu=@id
		FETCH cInserted INTO @id,@nom,@config,@dev,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Theme
on tblTheme
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idTheme,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblTheme
		SET tag=@nom+','+@descr
		WHERE idTheme=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Genre
on tblGenre
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idGenre,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblGenre
		SET tag=@nom+','+@descr
		WHERE idGenre=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Classification
on tblClassification
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idClassification,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblClassification
		SET tag=@nom+','+@descr
		WHERE idClassification=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Role
on tblRole
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idRole,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblRole
		SET tag=@nom+','+@descr
		WHERE idRole=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Employe
on tblEmploye
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @prenom as VARCHAR(1000)
	DECLARE @dateN as VARCHAR(1000)
	DECLARE @adresse as VARCHAR(1000)
	DECLARE @noTel as VARCHAR(1000)
	DECLARE @posteT as VARCHAR(1000)
	DECLARE @noTelM as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  matricule,nom,prenom,dateNaissance,adresse,noTelephone,posteTelephone,noTelephoneMaison FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@prenom,@dateN,@adresse,@noTel,@posteT,@noTelM;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblEmploye
		SET tag=@nom+','+@prenom+','+@dateN+','+@adresse+','+@noTel+','+@posteT+','+@noTelM
		WHERE matricule=@id
		FETCH cInserted INTO @id,@nom,@prenom,@dateN,@adresse,@noTel,@posteT,@noTelM;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END


CREATE TRIGGER TR_Equipe
on tblEquipe
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idEquipe,nom FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblEquipe
		SET tag=@nom
		WHERE idEquipe=@id
		FETCH cInserted INTO @id,@nom;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END

CREATE TRIGGER TR_Projet
on tblProjet
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idProjet,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblProjet
		SET tag=@nom+','+@descr
		WHERE idProjet=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END


CREATE TRIGGER TR_CategorieTest
on tblCategorieTest
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR(1000)
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idCategorieTest,nom,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblCategorieTest
		SET tag=@nom+','+@descr
		WHERE idCategorieTest=@id
		FETCH cInserted INTO @id,@nom,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END


CREATE TRIGGER TR_Test
on tblTest
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DECLARE @descr as VARCHAR(1000)
	
	

	DECLARE cInserted CURSOR FOR
			SELECT  idCategorieTest,description FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@descr;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		UPDATE tblTest
		SET tag=@descr
		WHERE idTest=@id
		FETCH cInserted INTO @id,@descr;
		
		END
	CLOSE cInserted
	DEALLOCATE cInserted
END











	