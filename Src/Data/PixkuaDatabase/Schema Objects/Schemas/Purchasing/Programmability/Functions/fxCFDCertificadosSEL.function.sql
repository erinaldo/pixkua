CREATE FUNCTION [Purchasing].[fxCFDCertificadosSEL](@RFC as char(13), @NumSerie as varchar(32))
RETURNS TABLE
AS
RETURN	(
	SELECT FechaInicial, FechaFinal, Estatus 
	FROM Purchasing.CFDCertificados 
	WHERE RFC=@RFC AND NumSerie=@NumSerie
		)


