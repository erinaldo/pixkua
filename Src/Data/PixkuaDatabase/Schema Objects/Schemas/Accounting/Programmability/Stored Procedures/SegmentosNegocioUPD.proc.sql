-- =============================================
-- Author: alex Lopez
-- Create date: 10-ene-2011
-- Description:	Agrega o modifica la información de SegmentosNegocio
-- =============================================
CREATE PROCEDURE [Accounting].[SegmentosNegocioUPD]
	@Id AS int out,
	@Codigo AS int,
	@Descripcion AS varchar(32),
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
		EXEC dbo.NewKey 'Accounting.SegmentosNegocio', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.SegmentosNegocio(IdSegmentoNegocio, Codigo, Descripcion, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Descripcion, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.SegmentosNegocio SET Codigo=@Codigo, Descripcion=@Descripcion, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdSegmentoNegocio=@ID


