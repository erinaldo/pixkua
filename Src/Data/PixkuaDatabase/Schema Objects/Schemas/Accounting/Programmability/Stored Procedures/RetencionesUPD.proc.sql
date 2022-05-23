-- =============================================
-- Author: alex Lopez
-- Create date: 24-nov-2011
-- Description:	Agrega o modifica la información de Retenciones
-- =============================================
CREATE PROCEDURE [Accounting].[RetencionesUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@Porcentaje AS decimal(7,6),
	@Abrev AS varchar(16),
	@TipoRetencion AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.Retenciones', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Retenciones(IdRetencion, Codigo, Nombre, Porcentaje, Abrev, TipoRetencion, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @Porcentaje, @Abrev, @TipoRetencion, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.Retenciones SET Codigo=@Codigo, Nombre=@Nombre, Porcentaje=@Porcentaje, Abrev=@Abrev, TipoRetencion=@TipoRetencion, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdRetencion=@ID


