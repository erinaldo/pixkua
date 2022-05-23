-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Agrega o modifica la información de TraspasosTit
-- =============================================
CREATE PROCEDURE [Inventory].[TraspasosTitUPD]
	@Id as char(18) out,
	@Fecha AS datetime,
	@IdConcepto AS int,
	@IdAlmacenOrigen AS int,
	@IdAlmacenDestino AS int,
	@Referencia AS char(18),
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
		-->Asignamos un guid vacío para el corte
		DECLARE @IdCorte as uniqueidentifier	
		SELECT @IdCorte=dbo.fxEmptyId()
	
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Traspaso') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Inventory.TraspasosTit(IdTraspasoTit, Fecha, IdConcepto, IdAlmacenOrigen, IdAlmacenDestino, 
			Referencia, Observaciones, TotalCantidad, TotalCosto, TotalFlete,
			IdMovimientoIN, IdMovimientoOUT, IdCorte,
			IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdConcepto, @IdAlmacenOrigen, @IdAlmacenDestino, 
			@Referencia, @Observaciones, 0, 0, 0,
			'', '', @IdCorte,
			@IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Inventory.TraspasosTit SET IdConcepto=@IdConcepto, IdAlmacenOrigen=@IdAlmacenOrigen, 
			IdAlmacenDestino=@IdAlmacenDestino, Referencia=@Referencia, Observaciones=@Observaciones, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdTraspasoTit=@ID and Fecha = Documents.fxDocumentDate(@id)


