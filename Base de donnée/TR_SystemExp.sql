CREATE TRIGGER TR_SystemExploitation
on tblSystemExploitation
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @id AS INT
	DEClARE @nom AS VARCHAR
	DECLARE @version AS VARCHAR
	DECLARE @edition as VARCHAR
	DECLARE @str as varchar

	DECLARE cInserted CURSOR FOR
			SELECT  idSysExp,nom,version,edition FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @id,@nom,@version,@edition;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
		
		@str=@id+","+@nom+","+@version+","+@edition
		
		UPDATE tblSystemExploitation
		SET tag=@str
		WHERE idSysExp=@id
		END
	
END

	