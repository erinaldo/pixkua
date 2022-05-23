-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Agrega o modifica la información de MaestrosIng
-- =============================================
CREATE PROCEDURE Production.MaestrosIngUPD
	@Id AS varchar out(18),
	@Fecha AS datetime,
	@IdOrdenTrabajoTipo AS int,
	@IdArticuloStock AS int,
	@IdInsumo AS int,
	@Cantidad AS decimal(19,4),
	@Saldo AS decimal(19,4),
	@IdUnidadMedida AS int,
	@IdOrdenTrabajoUltima AS varchar(18),
	@FechaOrdenTrabajoUltima AS datetime,
	@Observaciones AS varchar(256),
	@IdStatus AS int,
	@IdSucursal AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @Id=''
	BEGIN
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.spNewDocumentFolio @IdTipoDocumento,@IdSucursal,@Fecha,@Id Out
		
		INSERT INTO Production.MaestrosIng(IdMaestroIng, Fecha, IdOrdenTrabajoTipo, IdArticuloStock, IdInsumo, Cantidad, Saldo, IdUnidadMedida, IdOrdenTrabajoUltima, FechaOrdenTrabajoUltima, Observaciones, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdOrdenTrabajoTipo, @IdArticuloStock, @IdInsumo, @Cantidad, @Saldo, @IdUnidadMedida, @IdOrdenTrabajoUltima, @FechaOrdenTrabajoUltima, @Observaciones, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Production.MaestrosIng SET Fecha=@Fecha, IdOrdenTrabajoTipo=@IdOrdenTrabajoTipo, IdArticuloStock=@IdArticuloStock, IdInsumo=@IdInsumo, Cantidad=@Cantidad, Saldo=@Saldo, IdUnidadMedida=@IdUnidadMedida, IdOrdenTrabajoUltima=@IdOrdenTrabajoUltima, FechaOrdenTrabajoUltima=@FechaOrdenTrabajoUltima, Observaciones=@Observaciones, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdMaestroIng=@ID and Fecha = dbo.fxDocumentDate(@id)
