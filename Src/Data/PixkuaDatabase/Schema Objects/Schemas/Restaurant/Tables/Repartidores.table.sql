CREATE TABLE [Restaurant].[Repartidores](
	[IdRepartidor] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[NombreCorto] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Repartidores] PRIMARY KEY CLUSTERED 
(
	[IdRepartidor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


