-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Agrega o modifica la información de NotasDet
-- =============================================
CREATE PROCEDURE [Accounting].[NotasDetUPD]	
	@Id AS char(18),
	@Fecha AS datetime,
	@IdNotaConcepto AS int,
	@Concepto as varchar(128),
	@Monto AS decimal(19,4),
	@IdImpuestoTras1 AS int,
	@IdImpuestoTras2 AS int,
	@IdImpuestoTras3 AS int,
	@PorcImpTras1 AS decimal(7,6),
	@PorcImpTras2 AS decimal(7,6),
	@PorcImpTras3 AS decimal(7,6),
	@MontoImpTras1 AS decimal(19,4),
	@MontoImpTras2 AS decimal(19,4),
	@MontoImpTras3 AS decimal(19,4),
	@IdImpuestoRet1 AS int,
	@IdImpuestoRet2 AS int,
	@IdImpuestoRet3 AS int,
	@PorcImpRet1 AS decimal(7,6),
	@PorcImpRet2 AS decimal(7,6),
	@PorcImpRet3 AS decimal(7,6),
	@MontoImpRet1 AS decimal(19,4),
	@MontoImpRet2 AS decimal(19,4),
	@MontoImpRet3 AS decimal(19,4),
	@CodigoConcepto as varchar(32),
	@CuentaContable as varchar(64),
	@ConceptoLibre as bit
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdNotaTit FROM Accounting.NotasDet WHERE IdNotaTit=@Id and Fecha=Documents.fxDocumentDate(@Id) AND IdNotaConcepto=@IdNotaConcepto AND Concepto=@Concepto)
	BEGIN		
		INSERT INTO Accounting.NotasDet(IdNotaTit, Fecha, IdNotaConcepto, Concepto, Monto, IdImpuestoTras1, IdImpuestoTras2, 
			IdImpuestoTras3, PorcImpTras1, PorcImpTras2, PorcImpTras3, MontoImpTras1, MontoImpTras2, MontoImpTras3, 
			IdImpuestoRet1, IdImpuestoRet2, IdImpuestoRet3, PorcImpRet1, PorcImpRet2, PorcImpRet3, MontoImpRet1, 
			MontoImpRet2, MontoImpRet3)
		VALUES (@Id, @Fecha, @IdNotaConcepto, @Concepto, @Monto, @IdImpuestoTras1, @IdImpuestoTras2, 
			@IdImpuestoTras3, @PorcImpTras1, @PorcImpTras2, @PorcImpTras3, @MontoImpTras1, @MontoImpTras2, @MontoImpTras3, 
			@IdImpuestoRet1, @IdImpuestoRet2, @IdImpuestoRet3, @PorcImpRet1, @PorcImpRet2, @PorcImpRet3, @MontoImpRet1, 
			@MontoImpRet2, @MontoImpRet3)
	END
	ELSE
		UPDATE Accounting.NotasDet SET Monto=@Monto, IdImpuestoTras1=@IdImpuestoTras1, IdImpuestoTras2=@IdImpuestoTras2, 
			IdImpuestoTras3=@IdImpuestoTras3, PorcImpTras1=@PorcImpTras1, PorcImpTras2=@PorcImpTras2, 
			PorcImpTras3=@PorcImpTras3, MontoImpTras1=@MontoImpTras1, MontoImpTras2=@MontoImpTras2, 
			MontoImpTras3=@MontoImpTras3, IdImpuestoRet1=@IdImpuestoRet1, IdImpuestoRet2=@IdImpuestoRet2, 
			IdImpuestoRet3=@IdImpuestoRet3, PorcImpRet1=@PorcImpRet1, PorcImpRet2=@PorcImpRet2, 
			PorcImpRet3=@PorcImpRet3, MontoImpRet1=@MontoImpRet1, MontoImpRet2=@MontoImpRet2, 
			MontoImpRet3=@MontoImpRet3
		WHERE IdNotaTit=@Id and Fecha=Documents.fxDocumentDate(@Id) AND IdNotaConcepto=@IdNotaConcepto AND Concepto=@Concepto


