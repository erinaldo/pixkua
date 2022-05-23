-- =============================================
-- Author: RCO
-- Create date: 03-sep-2010
-- Description:	Agrega o modifica la información de UnidadesNegocio
-- =============================================
CREATE PROCEDURE [Sales].[UnidadesNegocioUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdEmpresa as int,
	@IdSucursal AS int,
	@AfectarInventario as bit,
	@AfectarInvLinea as bit,
	@IdAlmacen AS int,
	@IdRegion AS int,
	@IdZonaVenta AS int,
	@FactElectronica AS bit,
	@SerieFacturas AS char(3),
	@IdCFDSerie as int,
	@IdFormatoFactura as int,
	@IdSerieDevoluciones as int,
	@IdFormatoDevoluciones as int,
	@TipoPrecio AS char(1),
	@IdDivisaBase as int,
	@IdClienteGenerico AS int,
	@IdClienteFacturacion as int,
	@IdFormatoTicketComanda as int,
	@IdFormatoTicketPedimento as int,
	@IdFormatoTicketPOS as int,
	@GLN AS varchar(32),
	@IdRemitente as int,
	@IdOperador as int,
	@EnviarFacturas bit,
	@NotificarFacturas as bit,
	@NotificarFoliosTerminar as bit,
	@PorcentajeFolios as decimal(7,6),	
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Sales.UnidadesNegocio', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.UnidadesNegocio(IdUnidadNegocio, Codigo, Nombre, IdEmpresa, IdSucursal, AfectarInventario, AfectarInvLinea, IdAlmacen, 
			IdRegion, IdZonaVenta, FactElectronica, SerieFacturas, IdCFDSerie, IdFormatoFactura, IdFormatoTicketComanda,IdFormatoTicketPedimento,IdFormatoTicketPOS,
			IdSerieDevoluciones, IdFormatoDevoluciones, TipoPrecio, IdDivisaBase, IdClienteGenerico, IdClienteFacturacion, GLN, 
			IdRemitente, IdOperador, EnviarFacturas, NotificarFacturas, NotificarFoliosTerminar, PorcentajeFolios,
			IdStatus, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdEmpresa, @IdSucursal, @AfectarInventario, @AfectarInvLinea, @IdAlmacen, 
			@IdRegion, @IdZonaVenta, @FactElectronica, @SerieFacturas, @IdCFDSerie, @IdFormatoFactura,@IdFormatoTicketComanda, @IdFormatoTicketPedimento,@IdFormatoTicketPOS,
			@IdSerieDevoluciones, @IdFormatoDevoluciones, @TipoPrecio, @IdDivisaBase, @IdClienteGenerico, @IdClienteFacturacion, @GLN, 
			@IdRemitente, @IdOperador, @EnviarFacturas, @NotificarFacturas, @NotificarFoliosTerminar, @PorcentajeFolios,
			@IdStatus, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.UnidadesNegocio SET Codigo=@Codigo, Nombre=@Nombre, IdSucursal=@IdSucursal, 
			IdAlmacen=@IdAlmacen, AfectarInventario=@AfectarInventario, AfectarInvLinea=@AfectarInvLinea, IdRegion=@IdRegion, IdFormatoFactura=@IdFormatoFactura,
			IdZonaVenta=@IdZonaVenta, FactElectronica=@FactElectronica, SerieFacturas=@SerieFacturas, IdCFDSerie=@IdCFDSerie,			
			TipoPrecio=@TipoPrecio, IdDivisaBase=@IdDivisaBase, IdClienteGenerico=@IdClienteGenerico, IdClienteFacturacion=@IdClienteFacturacion, GLN=@GLN,
			IdFormatoTicketComanda=@IdFormatoTicketComanda,IdFormatoTicketPedimento=@IdFormatoTicketPedimento,IdFormatoTicketPOS=@IdFormatoTicketPOS,
			IdSerieDevoluciones=@IdSerieDevoluciones, IdFormatoDevoluciones=@IdFormatoDevoluciones, IdRemitente=@IdRemitente, 
			IdOperador=@IdOperador, EnviarFacturas=@EnviarFacturas, NotificarFacturas=@NotificarFacturas, 
			NotificarFoliosTerminar=@NotificarFoliosTerminar, PorcentajeFolios=@PorcentajeFolios, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdUnidadNegocio=@ID


