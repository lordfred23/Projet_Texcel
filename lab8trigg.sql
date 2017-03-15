CREATE TRIGGER Bonne_machine
on tblFormation
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @cours AS INT
	DEClARE @salle AS INT
	DECLARE @machine AS INT
	DECLARE @machineS as INT

	DECLARE cInserted CURSOR FOR
			SELECT coursForm ,salleForm FROM inserted;
	OPEN cInserted;
	FETCH cInserted INTO @cours,@salle;
	
	WHILE(@@FETCH_STATUS=0)BEGIN
	   
	 SET @machine =
	 (
		SELECT machineM
		FROM tblCoursMachine
		WHERE coursM=@cours
	 )
	 SET @machineS =
	 (
		SELECT machineN 
		FROM tblSalle
		WHERE IdSalle = @salle
	 )
END
	 
	 
	 
	 
		
		
	