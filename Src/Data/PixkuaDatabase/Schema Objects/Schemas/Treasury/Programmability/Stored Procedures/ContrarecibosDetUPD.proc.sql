-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Agrega o modifica la información de ContrarecibosDet
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosDetUPD]
	@Id AS int out,
	@IdContrareciboTit AS char(18),
	@Fecha AS datetime,
	@CodigoConcepto AS varchar(32),
	@DecripcionConcepto AS varchar(128),
	@IdCuenta AS int,
	@Monto AS decimal(19,4),
	@IdImpuesto1 AS int,
	@IdImpuesto2 AS int,
	@IdImpuesto3 AS int,
	@IdImpuesto4 AS int,
	@IdImpuesto5 AS int,
	@PorcImpTras1 AS decimal(7,6),
	@PorcImpTras2 AS decimal(7,6),
	@PorcImpTras3 AS decimal(7,6),
	@PorcImpTras4 AS decimal(7,6),
	@PorcImpTras5 AS decimal(7,6),
	@MontoImpTras1 AS decimal(19,4),
	@MontoImpTras2 AS decimal(19,4),
	@MontoImpTras3 AS decimal(19,4),
	@MontoImpTras4 AS decimal(19,4),
	@MontoImpTras5 AS decimal(19,4),
	@IdRetencion1 AS int,
	@IdRetencion2 AS int,
	@IdRetencion3 AS int,
	@IdRetencion4 AS int,
	@IdRetencion5 AS int,
	@PorcImpRet1 AS decimal(7,6),
	@PorcImpRet2 AS decimal(7,6),
	@PorcImpRet3 AS decimal(7,6),
	@PorcImpRet4 AS decimal(7,6),
	@PorcImpRet5 AS decimal(7,6),
	@MontoImpRet1 AS decimal(19,4),
	@MontoImpRet2 AS decimal(19,4),
	@MontoImpRet3 AS decimal(19,4),
	@MontoImpRet4 AS decimal(19,4),
	@MontoImpRet5 AS decimal(19,4)
	
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdContrareciboTit FROM Treasury.ContrarecibosDet WHERE IdContrareciboTit=@IdContrareciboTit and Fecha=Documents.fxDocumentDate(@IdContrareciboTit) AND CodigoConcepto=@CodigoConcepto AND DecripcionConcepto=@DecripcionConcepto AND IdCuenta=@IdCuenta )
	BEGIN		
		INSERT INTO Treasury.ContrarecibosDet(IdContrareciboDet, IdContrareciboTit, Fecha, CodigoConcepto, DecripcionConcepto, IdCuenta, Monto, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, MontoImpTras3, MontoImpTras4, MontoImpTras5, IdRetencion1, IdRetencion2, IdRetencion3, IdRetencion4, IdRetencion5, PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, MontoImpRet5)
		VALUES (@Id, @IdContrareciboTit, @Fecha, @CodigoConcepto, @DecripcionConcepto, @IdCuenta, @Monto, @IdImpuesto1, @IdImpuesto2, @IdImpuesto3, @IdImpuesto4, @IdImpuesto5, @PorcImpTras1, @PorcImpTras2, @PorcImpTras3, @PorcImpTras4, @PorcImpTras5, @MontoImpTras1, @MontoImpTras2, @MontoImpTras3, @MontoImpTras4, @MontoImpTras5, @IdRetencion1, @IdRetencion2, @IdRetencion3, @IdRetencion4, @IdRetencion5, @PorcImpRet1, @PorcImpRet2, @PorcImpRet3, @PorcImpRet4, @PorcImpRet5, @MontoImpRet1, @MontoImpRet2, @MontoImpRet3, @MontoImpRet4, @MontoImpRet5)
	END
	ELSE
		UPDATE Treasury.ContrarecibosDet SET  Monto=@Monto, IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3, IdImpuesto4=@IdImpuesto4, IdImpuesto5=@IdImpuesto5, PorcImpTras1=@PorcImpTras1, PorcImpTras2=@PorcImpTras2, PorcImpTras3=@PorcImpTras3, PorcImpTras4=@PorcImpTras4, PorcImpTras5=@PorcImpTras5, MontoImpTras1=@MontoImpTras1, MontoImpTras2=@MontoImpTras2, MontoImpTras3=@MontoImpTras3, MontoImpTras4=@MontoImpTras4, MontoImpTras5=@MontoImpTras5, IdRetencion1=@IdRetencion1, IdRetencion2=@IdRetencion2, IdRetencion3=@IdRetencion3, IdRetencion4=@IdRetencion4, IdRetencion5=@IdRetencion5, PorcImpRet1=@PorcImpRet1, PorcImpRet2=@PorcImpRet2, PorcImpRet3=@PorcImpRet3, PorcImpRet4=@PorcImpRet4, PorcImpRet5=@PorcImpRet5, MontoImpRet1=@MontoImpRet1, MontoImpRet2=@MontoImpRet2, MontoImpRet3=@MontoImpRet3, MontoImpRet4=@MontoImpRet4, MontoImpRet5=@MontoImpRet5
		WHERE IdContrareciboTit= @Id and Fecha = Documents.fxDocumentDate(@Id) AND CodigoConcepto=@CodigoConcepto AND DecripcionConcepto=@DecripcionConcepto AND IdCuenta=@IdCuenta


