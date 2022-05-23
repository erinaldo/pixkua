CREATE TABLE [Treasury].[ContrarecibosTit](
	[IdContrareciboTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdCaja] [int] NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
	[ReferenciaNum] [int] NOT NULL,
	[ReferenciaAlf] [varchar](32) NOT NULL,
	[FechaPago] [datetime] NULL,
	[IdChequeTit] [char](18) NOT NULL,
	[FechaCheque] [datetime] NULL,
	[IdBeneficiario] [int] NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_ContrarecibosTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdContrareciboTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


