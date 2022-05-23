CREATE PROCEDURE [Sales].[GrupoDescuentosServiciosUPD]
@IdGrupoDescuento as int, 
@IdServicio as int,
@PorcDescuento1 AS Decimal(19,4),
@PorcDescuento2 AS Decimal(19,4),
@PorcDescuento3 AS Decimal(19,4),
@PorcDescuento4 AS Decimal(19,4),
@PorcDescuento5 AS Decimal(19,4),
@LastUpdate AS datetime,
@PCUpdate AS varchar(32),
@UserUpdate AS int
AS
	IF NOT EXISTS(SELECT IdGrupoDescuentoServicio FROM Sales.GruposDescuentoServicios WHERE IdGrupoDescuento=@IdGrupoDescuento AND IdServicio=@IdServicio)
		INSERT INTO Sales.GruposDescuentoServicios(IdGrupoDescuento,IdServicio,PorcDescuento1,PorcDescuento2,PorcDescuento3,PorcDescuento4,PorcDescuento5,LastUpdate,UserUpdate,PCUpdate)
		VALUES (@IdGrupoDescuento,@IdServicio,@PorcDescuento1,@PorcDescuento2,@PorcDescuento3,@PorcDescuento4,@PorcDescuento5,@LastUpdate,@UserUpdate,@PCUpdate)
	ELSE
		UPDATE Sales.GruposDescuentoServicios
		SET PorcDescuento1=@PorcDescuento1,PorcDescuento2=@PorcDescuento2,PorcDescuento3=@PorcDescuento3,PorcDescuento4=@PorcDescuento4,PorcDescuento5=@PorcDescuento5,
			LastUpdate=@LastUpdate,UserUpdate=@UserUpdate,PcUpdate=@PcUpdate
		WHERE IdGrupoDescuento=@IdGrupoDescuento AND @IdServicio=@IdServicio


