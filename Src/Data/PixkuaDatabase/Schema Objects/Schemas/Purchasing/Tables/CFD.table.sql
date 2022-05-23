CREATE TABLE [Purchasing].[CFD](
	[IdProveedor] [int] NOT NULL,
	[Serie] [char](10) NOT NULL,
	[Folio] [int] NOT NULL,
	[UUID] [char](36) NOT NULL,
	[FechaComprobante] [datetime] NOT NULL,
	[HoraComprobante] [datetime] NOT NULL,
	[Comprobante] [xml] NOT NULL,
	[CadenaOriginal] [text] NOT NULL,
	[SelloDigital] [varchar](2048) NOT NULL,
	[NumCertificado] [char](20) NOT NULL,
	[AnioAprobacion] [int] NOT NULL,
	[NumAprobacion] [int] NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[Descuentos] [decimal](19, 4) NOT NULL,
	[ImpTrasladados] [decimal](19, 4) NOT NULL,
	[ImpRetenidos] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[Activa] [bit] NOT NULL,
	[FechaCancelacion] [datetime] NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[IdCFDTipo] [int] NOT NULL,
	[Referencia] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Purchasing_CFD] PRIMARY KEY NONCLUSTERED 
(
	[IdProveedor] ASC,
	[Serie] ASC,
	[Folio] ASC,
	[UUID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


