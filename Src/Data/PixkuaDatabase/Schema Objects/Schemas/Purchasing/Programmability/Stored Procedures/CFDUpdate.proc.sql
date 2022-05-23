CREATE PROCEDURE [Purchasing].[CFDUpdate]
	@IdProveedor as int,
	@Serie as char(10),
	@Folio as int,
	@UUID as char(36),
	@FechaComprobante as datetime,
	@HoraComprobante as datetime,
	@Comprobante as xml,
	@CadenaOriginal as text,
	@SelloDigital as varchar(2048),
	@NumCertificado as char(20),
	@AnioAprobacion as int,
	@NumAprobacion as int,
	@IdDivisa as int,
	@TipoCambio as decimal(19,4),
	@SubTotal as decimal(19,4),
	@Descuentos as decimal(19,4),
	@ImpuestosTras as decimal(19,4),
	@ImpuestosRet as decimal(19,4),
	@Total as decimal(19,4),
	@IdEmpresa as int,
	@IdSucursal as int,
	@FechaDocumento as datetime,
	@IdDocumento as char(18),
	@IdComprobanteTipo as int,
	@Referencia as varchar(32)
AS
	SET NOCOUNT ON

	IF EXISTS(SELECT Serie FROM Purchasing.CFD WHERE Serie=@Serie AND Folio=@Folio AND UUID=@UUID AND IdProveedor=@IdProveedor)
		UPDATE Purchasing.CFD SET IdDocumento=@IdDocumento, FechaDocumento=@FechaDocumento,
			FechaComprobante=@FechaComprobante, HoraComprobante=@HoraComprobante, Comprobante=@Comprobante,
			CadenaOriginal=@CadenaOriginal, SelloDigital=@SelloDigital, NumCertificado=@NumCertificado, 
			AnioAprobacion=@AnioAprobacion, NumAprobacion=@NumAprobacion, IdDivisa=@IdDivisa, TipoCambio=@TipoCambio,
			SubTotal=@SubTotal, Descuentos=@Descuentos, ImpTrasladados=@ImpuestosTras, ImpRetenidos=@ImpuestosRet,
			Total=@Total, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, IdCFDTipo=@IdComprobanteTipo
		WHERE IdProveedor=@IdProveedor AND Serie=@Serie AND Folio=@Folio AND UUID=@UUID
	ELSE
		INSERT INTO Purchasing.CFD (IdProveedor, Serie, Folio, UUID, FechaDocumento, IdDocumento, FechaComprobante, HoraComprobante, 
			Comprobante, CadenaOriginal, SelloDigital, NumCertificado, AnioAprobacion, NumAprobacion, 
			IdDivisa, TipoCambio, SubTotal, Descuentos, 
			ImpTrasladados, ImpRetenidos, Total, IdEmpresa, IdSucursal, IdCFDTipo, Referencia)
		VALUES (@IdProveedor, @Serie, @Folio, @UUID, @FechaDocumento, @IdDocumento, @FechaComprobante, @HoraComprobante, 
			@Comprobante, @CadenaOriginal, @SelloDigital, @NumCertificado, @AnioAprobacion, @NumAprobacion, 
			@IdDivisa, @TipoCambio, @SubTotal, @Descuentos, 
			@ImpuestosTras, @ImpuestosRet, @Total, @IdEmpresa, @IdSucursal, @IdComprobanteTipo, @Referencia)


