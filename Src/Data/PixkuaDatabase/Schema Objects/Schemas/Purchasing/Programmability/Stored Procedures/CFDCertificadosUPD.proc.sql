CREATE PROCEDURE [Purchasing].[CFDCertificadosUPD]
	@NumSerie as varchar(32),
	@FechaIni as datetime,
	@FechaFin as datetime,
	@RFC as char(13),
	@Estatus as char(1)
AS
	SET NOCOUNT ON
	
	INSERT INTO Purchasing.CFDCertificados (NumSerie, FechaInicial, FechaFinal, RFC, Estatus)
	VALUES (@NumSerie, @FechaInI, @FechaFin, @RFC, @Estatus)


