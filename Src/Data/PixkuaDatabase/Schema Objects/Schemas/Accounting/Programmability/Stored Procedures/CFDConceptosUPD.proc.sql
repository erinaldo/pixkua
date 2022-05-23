CREATE PROCEDURE [Accounting].[CFDConceptosUPD]
	@FechaComprobante as datetime,
	@IdCFDSerie as int,
	@Folio as int,
	@IdArticulo as int,
	@IdServicio as int,
	@Codigo as varchar(32),
	@Descripcion as varchar(512),
	@EAN as varchar(32),
	@Unidad as varchar(64),
	@Cantidad as decimal(19,4),
	@PrecioUnitario as decimal(19,4),
	@PorcImpTras1 as decimal(7,6),
	@PorcImpTras2 as decimal(7,6),
	@PorcImpTras3 as decimal(7,6),
	@PorcImpRet1 AS decimal(7,6),
	@PorcImpRet2 AS decimal(7,6),
	@PorcImpRet3 AS decimal(7,6),	
	@PorcDesc1 as decimal(7,6),
	@PorcDesc2 as decimal(7,6),
	@PorcDesc3 as decimal(7,6),
	@PorcDesc4 as decimal(7,6),
	@PorcDesc5 as decimal(7,6),
	@FactorUnidad as int,
	@IdDocumento as char(18),
	@FechaDocumento as datetime
AS
	SET NOCOUNT ON

	INSERT INTO Accounting.CFDConceptos(FechaComprobante, IdCFDSerie, Folio, IdArticulo, IdServicio, Codigo, Descripcion, EAN, Unidad, Cantidad,
		PrecioUnitario, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpRet1, PorcImpRet2, PorcImpRet3, 
		PorcDesc1, PorcDesc2, PorcDesc3, PorcDesc4, PorcDesc5, FactorUnidad, IdDocumento, FechaDocumento)
	VALUES (@FechaComprobante, @IdCFDSerie, @Folio, @IdArticulo, @IdServicio, @Codigo, @Descripcion, @EAN, @Unidad, @Cantidad,
		@PrecioUnitario, @PorcImpTras1, @PorcImpTras2, @PorcImpTras3, @PorcImpRet1, @PorcImpRet2, @PorcImpRet3, 
		@PorcDesc1, @PorcDesc2, @PorcDesc3, @PorcDesc4, @PorcDesc5, @FactorUnidad, @IdDocumento, @FechaDocumento)


