CREATE PROCEDURE [Treasury].[CajasAccesosDEL]
@IdCaja as int,
@IdUsuario as int
AS
	DELETE Treasury.CajasAccesos WHERE IdCaja=@IdCaja AND IdUsuario=@IdUsuario


