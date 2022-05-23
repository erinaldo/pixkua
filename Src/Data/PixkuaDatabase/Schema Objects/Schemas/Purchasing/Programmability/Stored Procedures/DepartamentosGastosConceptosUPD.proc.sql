CREATE PROCEDURE [Purchasing].[DepartamentosGastosConceptosUPD]
	@IdDepartamento as int out,
	@IdGastoConcepto AS int,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON

	DECLARE @LastUpdate as datetime
	SET @LastUpdate=GETDATE()

	IF NOT EXISTS (SELECT IdDepartamentoGastoConcepto FROM Purchasing.DepartamentosGastosConceptos WHERE IdDepartamento=@IdDepartamento AND IdGastoConcepto=@IdGastoConcepto )	
		INSERT INTO Purchasing.DepartamentosGastosConceptos(IdDepartamento,IdGastoConcepto, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@IdDepartamento, @IdGastoConcepto, @LastUpdate, @PCUpdate, @UserUpdate)


