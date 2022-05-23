CREATE PROCEDURE [Treasury].[CajasAccesosUPD]
@IdCaja as int,
@IdUsuario as int
AS
	IF NOT EXISTS(SELECT IdCajaAccesos FROM Treasury.CajasAccesos WHERE IdCaja=@IdCaja AND IdUsuario=@IdUsuario)
		INSERT INTO Treasury.CajasAccesos(IdCaja,IdUsuario) VALUES (@IdCaja,@IdUsuario)


