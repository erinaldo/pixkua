CREATE TABLE [dbo].[Sucursales](
	[IdSucursal] [int] NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[NombreLargo] [varchar](128) NOT NULL,
	[Tel1] [varchar](32) NOT NULL,
	[Tel2] [varchar](32) NOT NULL,
	[Fax] [varchar](32) NOT NULL,
	[PagWeb] [varchar](128) NOT NULL,
	[Correo] [varchar](128) NOT NULL,
	[Calle] [varchar](64) NOT NULL,
	[Colonia] [varchar](64) NOT NULL,
	[CP] [varchar](5) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[UserCreate] [int] NOT NULL,
 CONSTRAINT [PK_Sucursales] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


