CREATE TABLE [Sales].[UnidadesNegocio](
	[IdUnidadNegocio] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[AfectarInventario] [bit] NOT NULL,
	[AfectarInvLinea] [bit] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdRegion] [int] NOT NULL,
	[IdZonaVenta] [int] NOT NULL,
	[TipoPrecio] [char](1) NOT NULL,
	[IdDivisaBase] [int] NOT NULL,
	[FactElectronica] [bit] NOT NULL,
	[SerieFacturas] [char](10) NOT NULL,
	[UltimaFactura] [int] NOT NULL,
	[IdCFDSerie] [int] NOT NULL,
	[IdFormatoFactura] [int] NOT NULL,
	[IdSerieDevoluciones] [int] NOT NULL,
	[IdFormatoDevoluciones] [int] NOT NULL,
	[IdClienteGenerico] [int] NOT NULL,
	[IdClienteFacturacion] [int] NOT NULL,
	[IdFormatoTicketComanda] [int] NOT NULL,
	[IdFormatoTicketPedimento] [int] NOT NULL,
	[IdFormatoTicketPOS] [int] NOT NULL,
	[GLN] [varchar](32) NOT NULL,
	[IdRemitente] [int] NOT NULL,
	[IdOperador] [int] NOT NULL,
	[EnviarFacturas] [bit] NOT NULL,
	[NotificarFacturas] [bit] NOT NULL,
	[NotificarFoliosTerminar] [bit] NOT NULL,
	[PorcentajeFolios] [decimal](7, 6) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_UnidadesNegocio] PRIMARY KEY CLUSTERED 
(
	[IdUnidadNegocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Especifica si el precio se tomará de la zona de ventas, las listas de precio o alguna otra fuente.' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'UnidadesNegocio', @level2type=N'COLUMN',@level2name=N'TipoPrecio'

