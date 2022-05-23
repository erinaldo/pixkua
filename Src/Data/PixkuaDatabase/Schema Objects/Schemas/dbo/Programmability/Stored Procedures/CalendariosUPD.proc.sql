-- =============================================
-- Author: RCO
-- Create date: 14-jul-2011
-- Description:	Agrega o modifica la información de Calendarios
-- =============================================
CREATE PROCEDURE [dbo].[CalendariosUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(32),
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Calendarios', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Calendarios(IdCalendario, Codigo, Nombre, 
			IdSucursal, IdEmpresa, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @Nombre, 
			@IdSucursal, @IdEmpresa, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
	END
	ELSE
		UPDATE dbo.Calendarios SET Codigo=@Codigo, Nombre=@Nombre, 
			IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdCalendario=@ID


