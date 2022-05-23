CREATE PROCEDURE [Accounting].[CFDUpdate]
	@FechaComprobante as datetime,
	@HoraComprobante as datetime,	
	@IdCFDSerie as int,
	@Folio as int,
	@FechaDocumento as datetime,	
	@IdDocumento as char(18),
	@Comprobante as xml,	
	@CadenaOriginal as text,
	@SelloDigital as varchar(2048),
	@NumCertificado as char(20),
	@AnioAprobacion as int,
	@NumAprobacion as int,
	@IdCliente as int,	
	@CalleEnvio as varchar(128),
	@NumExtEnvio as varchar(32),
	@NumIntEnvio as varchar(32),
	@ColoniaEnvio as varchar(128),
	@LocalidadEnvio as varchar(64),
	@MunicipioEnvio as varchar(64),
	@EstadoEnvio as varchar(64),
	@PaisEnvio as varchar(64),
	@CPEnvio as char(5),
	@IdDivisa as int,
	@Divisa as varchar(32),
	@TipoCambio as decimal(19,4),
	@SubTotal as decimal(19,4),
	@Descuentos as decimal(19,4),
	@ImpTrasladados as decimal(19,4),
	@ImpRetenidos as decimal(19,4),
	@Total as decimal(19,4),	
	@IdSucursal as int,	
	@IdCFDTipo as int,
	@Credito as bit,
	@DiasCredito as int,
	@Referencia as varchar(32),
	@IdCFDAddenda as int,
	@GLNBuyer as varchar(32),
	@GLNStore as varchar(32),
	@GLNSeller as varchar(32),
	@SellerID as varchar(32),
	@UserUpdate as int=0,
	@PCUpdate as varchar(32)=''
AS
	SET NOCOUNT ON

	IF EXISTS(SELECT Folio FROM Accounting.CFD WHERE FechaComprobante=@FechaComprobante AND IdCFDSerie=@IdCFDSerie AND Folio=@Folio)
	BEGIN
		UPDATE Accounting.CFD SET FechaComprobante=@FechaComprobante, HoraComprobante=@HoraComprobante, 
			FechaDocumento=@FechaDocumento, IdDocumento=@IdDocumento, Comprobante=@Comprobante,
			CadenaOriginal=@CadenaOriginal, SelloDigital=@SelloDigital, NumCertificado=@NumCertificado, 
			AnioAprobacion=@AnioAprobacion, NumAprobacion=@NumAprobacion, IdCliente=@IdCliente,
			CalleEnvio=@CalleEnvio, NumExtEnvio=@NumExtEnvio, NumIntEnvio=@NumIntEnvio, ColoniaEnvio=@ColoniaEnvio,			
			LocalidadEnvio=@LocalidadEnvio, MunicipioEnvio=@MunicipioEnvio, EstadoEnvio=@EstadoEnvio, PaisEnvio=@PaisEnvio, CPEnvio=@CPEnvio,
			IdDivisa=@IdDivisa, Divisa=@Divisa, TipoCambio=@TipoCambio,
			SubTotal=@SubTotal, Descuentos=@Descuentos, ImpTrasladados=@ImpTrasladados, ImpRetenidos=@ImpRetenidos,
			Total=@Total, IdSucursal=@IdSucursal, IdCFDTipo=@IdCFDTipo, Credito=@Credito, DiasCredito=@DiasCredito,
			Referencia=@Referencia, IdCFDAddenda=@IdCFDAddenda, GLNBuyer=@GLNBuyer, GLNStore=@GLNStore,
			GLNSeller=@GLNSeller, SellerID=@SellerID, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE FechaComprobante=@FechaComprobante AND IdCFDSerie=@IdCFDSerie AND Folio=@Folio

		DELETE Accounting.CFDConceptos WHERE IdCFDSerie=@IdCFDSerie AND Folio=@Folio AND FechaComprobante=@FechaComprobante
	END
	ELSE
		INSERT INTO Accounting.CFD (
			FechaComprobante, HoraComprobante, IdCFDSerie, Folio,
			FechaDocumento, IdDocumento, Comprobante, CadenaOriginal, SelloDigital, NumCertificado,  
			AnioAprobacion, NumAprobacion, IdCliente, CalleEnvio, NumExtEnvio, NumIntEnvio, ColoniaEnvio,
			LocalidadEnvio, MunicipioEnvio, EstadoEnvio, PaisEnvio, CPEnvio, 
			IdDivisa, Divisa, TipoCambio, SubTotal, Descuentos, 
			ImpTrasladados, ImpRetenidos, Total, IdSucursal, IdCFDTipo, Credito, DiasCredito,
			Referencia, IdCFDAddenda, GLNBuyer, GLNStore, GLNSeller, SellerID, UserUpdate, PCUpdate
			)
		VALUES (
			@FechaComprobante, @HoraComprobante, @IdCFDSerie, @Folio, 
			@FechaDocumento, @IdDocumento, @Comprobante, @CadenaOriginal, @SelloDigital, @NumCertificado, 
			@AnioAprobacion, @NumAprobacion, @IdCliente, @CalleEnvio, @NumExtEnvio, @NumIntEnvio, @ColoniaEnvio,
			@LocalidadEnvio, @MunicipioEnvio, @EstadoEnvio, @PaisEnvio, @CPEnvio, 
			@IdDivisa, @Divisa, @TipoCambio, @SubTotal, @Descuentos, 
			@ImpTrasladados, @ImpRetenidos, @Total, @IdSucursal, @IdCFDTipo, @Credito, @DiasCredito,
			@Referencia, @IdCFDAddenda, @GLNBuyer, @GLNStore, @GLNSeller, @SellerID, @UserUpdate, @PCUpdate
			)


