CREATE TABLE [Purchasing].[Requisiciones](
	[IdRequisicion] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[IdRequisicionTipo] [int] NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[IdPresupuesto] [int] NOT NULL,
	[IdCentroRecepcion] [int] NOT NULL,
	[Observaciones] [varchar](256) NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[IdOrdenTit] [char](18) NOT NULL,
	[FechaOrden] [datetime] NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Requisiciones] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdRequisicion] ASC,
	[IdArticuloStock] ASC,
	[IdServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


