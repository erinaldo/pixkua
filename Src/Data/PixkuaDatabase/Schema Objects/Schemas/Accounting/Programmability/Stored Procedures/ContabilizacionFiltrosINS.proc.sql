CREATE PROCEDURE [Accounting].[ContabilizacionFiltrosINS]
@IdContabilizacionDocumentoDet as int,
@Filtro as varchar(8000),
@IdRacTit as int
AS	
	INSERT INTO Accounting.ContabilizacionFiltros(IdContabilizacionDocumentoDet,Filtro,IdRacTit)VALUES(@IdContabilizacionDocumentoDet,@Filtro,@IdRacTit)


