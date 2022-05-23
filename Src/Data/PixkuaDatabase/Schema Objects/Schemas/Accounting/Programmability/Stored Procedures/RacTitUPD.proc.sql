-- =============================================
-- Author: alex Lopez
-- Create date: 08-oct-2010
-- Description:	Agrega o modifica la información de RacTit
-- =============================================
CREATE PROCEDURE [Accounting].[RacTitUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdPolizaPerfil AS int,
	@IdSegmentoNegocio as int=0,
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
		EXEC dbo.NewKey 'Accounting.RacTit', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.RacTit(IdRacTit, Codigo, Nombre, IdPolizaPerfil, IdSegmentoNegocio, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdPolizaPerfil, @IdSegmentoNegocio, @IdStatus,@IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.RacTit SET Codigo=@Codigo, Nombre=@Nombre, IdPolizaPerfil=@IdPolizaPerfil, IdSegmentoNegocio=@IdSegmentoNegocio, IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdRacTit=@ID


