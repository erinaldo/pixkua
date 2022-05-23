CREATE PROCEDURE [Sales].[GrupoDescuentosArticulosUPD]
@IdGrupoDescuento as int, 
@IdArticuloStock as int,
@PorcDescuento1 AS Decimal(19,4),
@PorcDescuento2 AS Decimal(19,4),
@PorcDescuento3 AS Decimal(19,4),
@PorcDescuento4 AS Decimal(19,4),
@PorcDescuento5 AS Decimal(19,4),
@LastUpdate AS datetime,
@PCUpdate AS varchar(32),
@UserUpdate AS int
AS
	IF NOT EXISTS(SELECT IdGrupoDescuentoArticulo FROM Sales.GruposDescuentoArticulos WHERE IdGrupoDescuento=@IdGrupoDescuento AND IdArticuloStock=@IdArticuloStock)
		INSERT INTO Sales.GruposDescuentoArticulos(IdGrupoDescuento,IdArticuloStock,PorcDescuento1,PorcDescuento2,PorcDescuento3,PorcDescuento4,PorcDescuento5,LastUpdate,UserUpdate,PCUpdate)
		VALUES (@IdGrupoDescuento,@IdArticuloStock,@PorcDescuento1,@PorcDescuento2,@PorcDescuento3,@PorcDescuento4,@PorcDescuento5,@LastUpdate,@UserUpdate,@PCUpdate)
	ELSE
		UPDATE Sales.GruposDescuentoArticulos 
		SET PorcDescuento1=@PorcDescuento1,PorcDescuento2=@PorcDescuento2,PorcDescuento3=@PorcDescuento3,PorcDescuento4=@PorcDescuento4,PorcDescuento5=@PorcDescuento5,
			LastUpdate=@LastUpdate,UserUpdate=@UserUpdate,PcUpdate=@PcUpdate
		WHERE IdGrupoDescuento=@IdGrupoDescuento AND IdArticuloStock=@IdArticuloStock


