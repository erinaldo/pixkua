CREATE PROCEDURE [Purchasing].[CFDConceptosUPD]
	@IdProveedor as int,
	@Serie as char(10),
	@Folio as int,
	@UUID as char(36),
	@Codigo as varchar(16),
	@Descripcion as varchar(256),
	@EAN as varchar(32),
	@Unidad as varchar(64),
	@Cantidad as decimal(19,4),	
	@PrecioUnitario as decimal(19,4),
	@FactorUnidad as int,
	@IdArticuloStock as int,
	@IdServicio as int,
	@PorcImpTras1 as decimal(7,6),
	@PorcImpTras2 as decimal(7,6),
	@PorcImpTras3 as decimal(7,6),
	@PorcImpRet1 as decimal(7,6),
	@PorcImpRet2 as decimal(7,6),
	@PorcImpRet3 as decimal(7,6),
	@PorcDesc1 as decimal(7,6),
	@PorcDesc2 as decimal(7,6),
	@PorcDesc3 as decimal(7,6),
	@FechaDocumento as datetime,
	@IdDocumento as char(18)
AS
	SET NOCOUNT ON

	INSERT INTO Purchasing.CFDConceptos(IdProveedor, Serie, Folio, UUID, Codigo, Descripcion, EAN, PrecioUnitario, Cantidad, 
		FactorUnidad, Unidad, IdArticuloStock, IdServicio, PorcImpTras1, PorcImpTras2, PorcImpTras3, 
		PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcDesc1, PorcDesc2,PorcDesc3,
		FechaDocumento, IdDocumento)
	VALUES (@IdProveedor, @Serie, @Folio, @UUID, @Codigo, @Descripcion, @EAN, @PrecioUnitario, @Cantidad, 
		@FactorUnidad, @Unidad, @IdArticuloStock, @IdServicio, @PorcImpTras1, @PorcImpTras2, @PorcImpTras3, 
		@PorcImpRet1, @PorcImpRet2, @PorcImpRet3, @PorcDesc1, @PorcDesc2, @PorcDesc3,
		@FechaDocumento, @IdDocumento)


