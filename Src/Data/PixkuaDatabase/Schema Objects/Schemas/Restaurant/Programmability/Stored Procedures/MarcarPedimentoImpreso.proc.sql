CREATE PROCEDURE [Restaurant].[MarcarPedimentoImpreso]
@IdComandaTit as char(18),
@IdCentrosProdImpresos as varchar(512)
AS
	UPDATE Restaurant.ComandaDet SET Entregado=Cantidad 
	WHERE IdComandaTit=@IdComandaTit AND IdCentroProduccion IN (SELECT IdReturn FROM dbo.fxConvertIDsToTable(@IdCentrosProdImpresos))


