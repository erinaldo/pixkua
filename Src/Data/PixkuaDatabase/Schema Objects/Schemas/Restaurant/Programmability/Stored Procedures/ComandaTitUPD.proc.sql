-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Agrega o modifica la información de ComandaTit
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaTitUPD]
	@Id AS char(18)out,
	@Fecha AS datetime,
	@IdMesero AS int,
	@IdMesa AS int,
	@IdCliente AS int,
	@IdRepartidor AS int,
	@Observaciones AS varchar(128),
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
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Restaurant.ComandaTit') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Restaurant.ComandaTit(IdComandaTit, Fecha, IdMesero, IdMesa, IdCliente, IdRepartidor, Observaciones, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdMesero,@IdMesa, @IdCliente, @IdRepartidor, @Observaciones, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
		
		IF @IdMesa > 0
		BEGIN
			UPDATE Restaurant.Mesas SET IdComandaTit =@Id WHERE IdMesa=@IdMesa
		END
		
	END
	ELSE
		UPDATE Restaurant.ComandaTit SET Fecha=@Fecha, IdMesero=@IdMesero,IdMesa=@IdMesa,IdCliente=@IdCliente,IdRepartidor=@IdRepartidor,Observaciones=@Observaciones, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdComandaTit=@ID and Fecha = Documents.fxDocumentDate(@id)


