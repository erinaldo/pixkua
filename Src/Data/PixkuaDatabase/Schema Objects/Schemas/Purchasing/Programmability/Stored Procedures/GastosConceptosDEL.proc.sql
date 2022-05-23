CREATE PROCEDURE  [Purchasing].[GastosConceptosDEL]
@IdGastoConceptoTipo as int out,
@IdGastoConcepto AS int
AS
	UPDATE  Purchasing.GastosConceptos SET @IdGastoConceptoTipo=0,IdStatus=0 WHERE IdGastoConceptoTipo=@IdGastoConceptoTipo AND IdGastoConcepto=@IdGastoConcepto


