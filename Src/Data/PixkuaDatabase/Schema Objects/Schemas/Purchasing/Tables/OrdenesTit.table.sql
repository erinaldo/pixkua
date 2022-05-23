CREATE TABLE [Purchasing].[OrdenesTit](
	[IdOrdenTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[IdPresupuesto] [int] NOT NULL,
	[IdCentroRecepcion] [int] NOT NULL,
	[FechaEntrega] [datetime] NULL,
	[Referencia] [varchar](32) NOT NULL,
	[IdReferencia] [char](18) NOT NULL,
	[Origen] [char](1) NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[TotalDescuentos] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[Obaservaciones] [varchar](128) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_OrdenesTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdOrdenTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


