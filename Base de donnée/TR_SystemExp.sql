
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
	DECLARE @str as varchar(1000)

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

	