CREATE TABLE [Documents].[DocumentosTit](
	[IdDocumentoTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdTipo] [int] NOT NULL,
	[IdDocOrigen] [char](18) NOT NULL,
	[Serie] [char](3) NOT NULL,
	[Folio] [int] NOT NULL,
	[IdCondicionPago] [int] NOT NULL,
	[VigenciaPago] [datetime] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdActor] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
	[TotalCant] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestos] [decimal](19, 4) NOT NULL,
	[TotalDescuentos] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[IdMoneda] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[Notas] [varchar](256) NOT NULL,
	[Referencia] [varchar](32) NOT NULL,
	[IdReferencia] [char](18) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_DocumentosTit] PRIMARY KEY CLUSTERED 
(
	[IdDocumentoTit] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


