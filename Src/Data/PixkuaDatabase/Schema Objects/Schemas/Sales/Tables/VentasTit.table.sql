CREATE TABLE [Sales].[VentasTit](
	[IdVentaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[IdReferencia] [char](18) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdVendedor] [int] NOT NULL,
	[IdTerminal] [int] NOT NULL,
	[IdCaja] [int] NOT NULL,
	[IdCorte] [uniqueidentifier] NOT NULL,
	[CondicionesPago] [char](1) NOT NULL,
	[FechaPago] [datetime] NULL,
	[IdCFDSerie] [int] NOT NULL,
	[SerieFactura] [char](10) NOT NULL,
	[FolioFactura] [int] NOT NULL,
	[FechaFactura] [datetime] NULL,
	[IdListaPrecio] [int] NOT NULL,
	[Observaciones] [varchar](256) NOT NULL,
	[OrdenCompra] [varchar](32) NOT NULL,
	[TotalCantidad] [decimal](19, 4) NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[TotalDescuentos] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[TotalComision] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[TotalIVA] [decimal](19, 4) NOT NULL,
	[TotalIEPS] [decimal](19, 4) NOT NULL,
	[Origen] [char](1) NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdSalida] [char](18) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_VentasTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdVentaTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica las condiciones de pago: C=Crédito, E=Contado' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'VentasTit', @level2type=N'COLUMN',@level2name=N'CondicionesPago'

