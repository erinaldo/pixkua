-- =============================================
-- Author: RCO
-- Create date: 11-oct-2010
-- Description:	Agrega o modifica la información de Turnos
-- =============================================
CREATE PROCEDURE [Inventory].[TurnosUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@HoraInicial AS datetime,
	@HoraFinal AS datetime,
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.Turnos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.Turnos(IdTurno, Codigo, Nombre, HoraInicial, HoraFinal, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @HoraInicial, @HoraFinal, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.Turnos SET Codigo=@Codigo, Nombre=@Nombre, HoraInicial=@HoraInicial, HoraFinal=@HoraFinal, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdTurno=@ID


