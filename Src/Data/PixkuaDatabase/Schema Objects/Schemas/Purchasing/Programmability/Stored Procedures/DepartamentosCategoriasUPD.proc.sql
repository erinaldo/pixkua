CREATE PROCEDURE [Purchasing].[DepartamentosCategoriasUPD]
	@IdDepartamento as int out,
	@IdCategoriaPresupuestal AS int,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON

	DECLARE @LastUpdate as datetime
	SET @LastUpdate=GETDATE()

	IF NOT EXISTS (SELECT IdDepartamentoCategoria FROM Purchasing.DepartamentosCategorias WHERE IdDepartamento=@IdDepartamento AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal )	
		INSERT INTO Purchasing.DepartamentosCategorias(IdDepartamento,IdCategoriaPresupuestal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@IdDepartamento, @IdCategoriaPresupuestal, @LastUpdate, @PCUpdate, @UserUpdate)


