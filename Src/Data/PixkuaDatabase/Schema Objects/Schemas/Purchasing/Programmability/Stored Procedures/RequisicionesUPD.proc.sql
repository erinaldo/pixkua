-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Agrega o modifica la información de Requisiciones
-- =============================================
CREATE PROCEDURE [Purchasing].[RequisicionesUPD]
	@Id AS char (18)out,
	@Fecha AS datetime,
	@IdArticuloStock AS int,
	@IdServicio AS int,
	@IdRequisicionTipo AS int,
	@IdDepartamento as int,
	@IdPresupuesto AS int,
	@IdCentroRecepcion AS int,
	@Observaciones AS varchar(256),
	@Cantidad AS decimal(19,4),
	@IdUnidadMedida AS int,
	@IdCategoriaPresupuestal  AS int,
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
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','RequisicionCompra') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Purchasing.Requisiciones(IdRequisicion, Fecha, IdArticuloStock, IdServicio, IdRequisicionTipo, IdDepartamento, IdPresupuesto, IdCentroRecepcion, Observaciones, Cantidad, IdUnidadMedida, IdCategoriaPresupuestal,  IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdArticuloStock, @IdServicio, @IdRequisicionTipo, @IdDepartamento,@IdPresupuesto, @IdCentroRecepcion, @Observaciones, @Cantidad, @IdUnidadMedida, @IdCategoriaPresupuestal, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Purchasing.Requisiciones SET Fecha=@Fecha, IdArticuloStock=@IdArticuloStock, IdServicio=@IdServicio, IdRequisicionTipo=@IdRequisicionTipo, IdDepartamento=@IdDepartamento, IdPresupuesto=@IdPresupuesto, IdCentroRecepcion=@IdCentroRecepcion, Observaciones=@Observaciones, Cantidad=@Cantidad, IdUnidadMedida=@IdUnidadMedida, IdCategoriaPresupuestal=@IdCategoriaPresupuestal, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdRequisicion=@ID and Fecha = Documents.fxDocumentDate(@id)


