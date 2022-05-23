CREATE TABLE [Restaurant].[Mesas](
	[IdMesa] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Descripcion] [varchar](32) NOT NULL,
	[IdCentroConsumo] [int] NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdComandaTit] [varchar](18) NOT NULL,
	[IdMesaAgrupada] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[IdMesa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


