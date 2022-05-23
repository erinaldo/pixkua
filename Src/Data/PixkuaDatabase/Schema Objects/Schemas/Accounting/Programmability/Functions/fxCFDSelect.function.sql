CREATE FUNCTION [Accounting].[fxCFDSelect](@FechaComprobante as datetime, @IdCFDSerie as int, @Folio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT C.IdCFDSerie, C.FechaDocumento, C.IdDocumento, C.Comprobante, C.IdCliente, 
		C.CalleEnvio, C.NumExtEnvio, C.NumIntEnvio, C.ColoniaEnvio, C.LocalidadEnvio, 
		C.MunicipioEnvio, C.EstadoEnvio, C.PaisEnvio, C.CPEnvio,
		C.Activa, C.FechaCancelacion, C.IdSucursal, C.IdCFDTipo, C.Credito, C.DiasCredito,
		C.Referencia, C.IdCFDAddenda, C.GLNBuyer, C.GLNStore, C.GLNSeller, C.SellerID,
		C.IdDivisa, C.TipoCambio, D.Nombre AS Divisa
	FROM Accounting.CFD C JOIN Accounting.Divisas D
		ON C.IdDivisa=D.IdDivisa
	WHERE C.FechaComprobante=@FechaComprobante AND C.IdCFDSerie=@IdCFDSerie AND C.Folio=@Folio
		)


