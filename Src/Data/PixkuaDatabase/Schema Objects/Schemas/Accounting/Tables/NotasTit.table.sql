CREATE TABLE [Accounting].[NotasTit](
	[IdNotaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Tipo] [char](1) NOT NULL,
	[IdCFDSerie] [int] NOT NULL,
	[FolioNota] [int] NOT NULL,
	[FechaNota] [datetime] NULL,
	[IdSerieRef] [char](10) NOT NULL,
	[FolioRef] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[RFC] [varchar](16) NOT NULL,
	[RazonSocial] [varchar](256) NOT NULL,
	[Calle] [varchar](128) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[Colonia] [varchar](128) NOT NULL,
	[CP] [char](5) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[Observaciones] [varchar](256) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_NotasTit] PRIMARY KEY CLUSTERED 
(
	[IdNotaTit] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


