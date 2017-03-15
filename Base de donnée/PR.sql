CREATE PROCEDURE PR_SystemExploitation
    AS
    EXEC ('

    CREATE VIEW vwSystemExploitation
    AS

    SELECT *
    FROM tblSystemExploitation
	')