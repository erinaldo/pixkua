CREATE PROCEDURE [Production].[InsumosArticulosUPD]
	@IdInsumo AS int,
	@IdArticuloStock AS int,
	@Predeterminado as bit,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdInsumoArticulo FROM Production.InsumosArticulos WHERE IdInsumo=@IdInsumo AND IdArticuloStock=@IdArticuloStock)
	BEGIN		
		INSERT INTO Production.InsumosArticulos (IdInsumo,IdArticuloStock,Predeterminado)
		VALUES (@IdInsumo, @IdArticuloStock,@Predeterminado)
	END
	ELSE
		UPDATE Production.InsumosArticulos  SET Predeterminado=@Predeterminado
		WHERE IdInsumo=@IdInsumo AND IdArticuloStock=@IdArticuloStock


