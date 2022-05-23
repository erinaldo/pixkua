CREATE TABLE [Purchasing].[CentrosRecepcion](
	[IdCentroRecepcion] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Calle] [varchar](64) NOT NULL,
	[Colonia] [varchar](64) NOT NULL,
	[CP] [varchar](5) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[IdMunicipio] [int] NOT NULL,
	[Tel1] [varchar](32) NOT NULL,
	[Tel2] [varchar](32) NOT NULL,
	[Fax] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_CentrosRecepcion] PRIMARY KEY CLUSTERED 
(
	[IdCentroRecepcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


