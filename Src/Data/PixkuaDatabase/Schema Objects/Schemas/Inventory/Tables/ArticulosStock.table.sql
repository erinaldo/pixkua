CREATE TABLE [Inventory].[ArticulosStock](
	[IdArticuloStock] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[Descripcion] [varchar](256) NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[StockMax] [decimal](19, 4) NOT NULL,
	[StockMin] [decimal](19, 4) NOT NULL,
	[PuntoReorden] [decimal](19, 4) NOT NULL,
	[UltimoCosto] [decimal](19, 4) NOT NULL,
	[CostoPromedio] [decimal](19, 4) NOT NULL,
	[Orden] [int] NOT NULL,
	[EAN] [varchar](32) NOT NULL,
	[Origen] [char](1) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_ArticulosStock] PRIMARY KEY CLUSTERED 
(
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


