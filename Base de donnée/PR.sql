CREATE PROCEDURE PR_SystemExploitation
    AS
    EXEC ('

    CREATE VIEW vwSystemExploitation
    AS

    SELECT *
    FROM tblSystemExploitation
	');

CREATE PROCEDURE PR_Platform
    AS
    EXEC ('

    CREATE VIEW vwPlatform
    AS

    SELECT *
    FROM tblPlatform
	');

CREATE PROCEDURE PR_Jeu
    AS
    EXEC ('

    CREATE VIEW vwJeu
    AS

    SELECT *
    FROM tblJeu
	');
	
CREATE PROCEDURE PR_Theme
    AS
    EXEC ('

    CREATE VIEW vwTheme
    AS

    SELECT *
    FROM tblTheme
	');
	
CREATE PROCEDURE PR_Genre
    AS
    EXEC ('

    CREATE VIEW vwGenre
    AS

    SELECT *
    FROM tblGenre
	');
	
CREATE PROCEDURE PR_Classification
    AS
    EXEC ('

    CREATE VIEW vwClassification
    AS

    SELECT *
    FROM tblClassification
	');
	
CREATE PROCEDURE PR_Role
    AS
    EXEC ('

    CREATE VIEW vwRole
    AS

    SELECT *
    FROM tblRole
	');
	
CREATE PROCEDURE PR_Employe
    AS
    EXEC ('

    CREATE VIEW vwEmploye
    AS

    SELECT *
    FROM tblEmploye
	');
	
CREATE PROCEDURE PR_Equipe
    AS
    EXEC ('

    CREATE VIEW vwEquipe
    AS

    SELECT *
    FROM tblEquipe
	');
	
CREATE PROCEDURE PR_Projet
    AS
    EXEC ('

    CREATE VIEW vwProjet
    AS

    SELECT *
    FROM tblProjet
	');
	
CREATE PROCEDURE PR_CategorieTest
    AS
    EXEC ('

    CREATE VIEW vwCategorieTest
    AS

    SELECT *
    FROM tblCategorieTest
	');
	
CREATE PROCEDURE PR_Test
    AS
    EXEC ('

    CREATE VIEW vwTest
    AS

    SELECT *
    FROM tblTest
	');
	
	
	
	