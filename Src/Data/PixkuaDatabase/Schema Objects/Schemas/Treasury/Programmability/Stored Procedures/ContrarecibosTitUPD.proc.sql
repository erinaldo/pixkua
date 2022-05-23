-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Agrega o modifica la información de ContrarecibosTit
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosTitUPD]
	@Id AS char (18)out,
	@Fecha AS datetime,
	@IdCaja AS int,
	@IdDocumento AS char(18),
	@FechaDocumento AS datetime,
	@ReferenciaNum AS int,
	@ReferenciaAlf AS varchar(32),
	@FechaPago AS datetime=Null,
	@IdBeneficiario AS int,
	@SubTotal AS decimal(19,4),
	@TotalImpuestosTras AS decimal(19,4),
	@TotalImpuestosRet AS decimal(19,4),
	@Total AS decimal(19,4),
	@IdStatus AS int,
	@IdSucursal as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @Id=''
	BEGIN
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Contrarecibos') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Treasury.ContrarecibosTit(IdContrareciboTit, Fecha, IdCaja, IdDocumento, FechaDocumento, ReferenciaNum, ReferenciaAlf, FechaPago,IdBeneficiario, SubTotal, TotalImpuestosTras, TotalImpuestosRet, Total, IdStatus, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Fecha, @IdCaja, @IdDocumento, @FechaDocumento, @ReferenciaNum, @ReferenciaAlf, @FechaPago, @IdBeneficiario, @SubTotal, @TotalImpuestosTras, @TotalImpuestosRet, @Total, @IdStatus, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Treasury.ContrarecibosTit SET IdCaja=@IdCaja, IdDocumento=@IdDocumento, FechaDocumento=@FechaDocumento, ReferenciaNum=@ReferenciaNum, ReferenciaAlf=@ReferenciaAlf, FechaPago=@FechaPago, IdBeneficiario=@IdBeneficiario, SubTotal=@SubTotal, TotalImpuestosTras=@TotalImpuestosTras, TotalImpuestosRet=@TotalImpuestosRet, Total=@Total, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdContrareciboTit=@ID and Fecha = Documents.fxDocumentDate(@id)


