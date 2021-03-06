CREATE TABLE [Accounting].[CFD](
	[FechaComprobante] [datetime] NOT NULL,
	[IdCFDSerie] [int] NOT NULL,
	[Folio] [int] NOT NULL,
	[HoraComprobante] [datetime] NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[Comprobante] [xml] NOT NULL,
	[CadenaOriginal] [text] NOT NULL,
	[SelloDigital] [varchar](2048) NOT NULL,
	[NumCertificado] [char](20) NOT NULL,
	[AnioAprobacion] [int] NOT NULL,
	[NumAprobacion] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[CalleEnvio] [varchar](128) NOT NULL,
	[NumExtEnvio] [varchar](32) NOT NULL,
	[NumIntEnvio] [varchar](32) NOT NULL,
	[ColoniaEnvio] [varchar](128) NOT NULL,
	[LocalidadEnvio] [varchar](64) NOT NULL,
	[MunicipioEnvio] [varchar](64) NOT NULL,
	[EstadoEnvio] [varchar](64) NOT NULL,
	[PaisEnvio] [varchar](64) NOT NULL,
	[CPEnvio] [char](5) NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[Divisa] [varchar](32) NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[Descuentos] [decimal](19, 4) NOT NULL,
	[ImpTrasladados] [decimal](19, 4) NOT NULL,
	[ImpRetenidos] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[Activa] [bit] NOT NULL,
	[FechaCancelacion] [datetime] NULL,
	[IdSucursal] [int] NOT NULL,
	[IdCFDTipo] [int] NOT NULL,
	[Credito] [bit] NOT NULL,
	[DiasCredito] [int] NOT NULL,
	[Referencia] [varchar](32) NOT NULL,
	[IdCFDAddenda] [int] NOT NULL,
	[GLNBuyer] [varchar](32) NOT NULL,
	[GLNStore] [varchar](32) NOT NULL,
	[GLNSeller] [varchar](32) NOT NULL,
	[SellerID] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_CFD] PRIMARY KEY CLUSTERED 
(
	[FechaComprobante] ASC,
	[IdCFDSerie] ASC,
	[Folio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


