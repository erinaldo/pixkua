CREATE PROCEDURE [Restaurant].[CentrosProduccionArticulosUPD]
	@IdCentroProduccionArticulo as int out,
	@IdCentroProduccion AS int,
	@IdArticulo AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @IdCentroProduccionArticulo=0
	BEGIN		
		INSERT INTO Restaurant.CentrosProduccionArticulos(IdCentroProduccion,IdArticulo, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@IdCentroProduccion, @IdArticulo, @LastUpdate, @PCUpdate, @UserUpdate)
		SET @IdCentroProduccionArticulo=@@IDENTITY
	END
	ELSE
		UPDATE Restaurant.CentrosProduccionArticulos SET IdArticulo=@IdArticulo, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCentroProduccionArticulo =@IdCentroProduccionArticulo


