-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Agrega o modifica la información de ComandaDet
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaDetUPD]
	@Id as varchar(32),
	@Fecha as datetime,
	@IdCentroProduccion as int,
	@IdArticulo AS int,
	@IdArticuloStock as int,
	@Cantidad AS decimal(19,4),
	@Entregado as decimal(19,4),
	@PrecioUnitario AS decimal(18,4),
	@Observaciones AS varchar(128),
    @Articulo as varchar(128),
    @IdImpuesto1 as integer,
    @IdImpuesto2 as integer,
    @IdImpuesto3 as integer,
    @PorImpto1 as decimal(19,4),
    @PorImpto2 as decimal(19,4),
    @PorImpto3 as decimal(19,4),
    @PrecioNeto as decimal(19,4)
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdComandaTit FROM Restaurant.ComandaDet WHERE IdComandaTit=@Id and Fecha=Documents.fxDocumentDate(@Id)AND IdCentroProduccion=@IdCentroProduccion AND IdArticulo=@IdArticulo )
	BEGIN		
		INSERT INTO Restaurant.ComandaDet(IdComandaTit, Fecha,IdCentroProduccion, IdArticulo, Cantidad, Entregado,PrecioUnitario, Observaciones, IdImpuesto1,IdImpuesto2, IdImpuesto3, PorcImpto1, PorcImpto2 ,PorcImpto3 )
		VALUES (@Id, @Fecha,@IdCentroProduccion, @IdArticulo, @Cantidad, @Entregado, @PrecioUnitario, @Observaciones, @IdImpuesto1,@IdImpuesto2, @IdImpuesto3, @PorImpto1, @PorImpto2, @PorImpto3)
	END
	ELSE
		UPDATE Restaurant.ComandaDet SET IdComandaTit=@Id, Fecha=@Fecha,IdCentroProduccion=@IdCentroProduccion, IdArticulo=@IdArticulo, Cantidad=@Cantidad, Entregado=@Entregado, PrecioUnitario=@PrecioUnitario, Observaciones=@Observaciones, IdImpuesto1=@IdImpuesto1,IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3, PorcImpto1 =@PorImpto1, PorcImpto2=@PorImpto2, PorcImpto3=@PorImpto3
		WHERE IdComandaTit= @Id and Fecha = Documents.fxDocumentDate(@Id)


