-- =============================================
-- Author: RCO
-- Create date: 09-sep-2010
-- Description:	Agrega o modifica la información de Impuestos
-- =============================================
CREATE PROCEDURE [Accounting].[ImpuestosUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@Porcentaje AS decimal(7,6),
	@Abrev AS varchar(16),
	@TipoImpuesto as int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,	
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.Impuestos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Impuestos(IdImpuesto, Codigo, Nombre, Porcentaje, Abrev, TipoImpuesto,
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Porcentaje, @Abrev, @TipoImpuesto,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.Impuestos SET Codigo=@Codigo, Nombre=@Nombre, Porcentaje=@Porcentaje, Abrev=@Abrev, TipoImpuesto=@TipoImpuesto,
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdImpuesto=@ID


