CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[ApellidoP] [varchar](64) NOT NULL,
	[ApellidoM] [varchar](64) NOT NULL,
	[Calle] [varchar](64) NOT NULL,
	[Cruce1] [varchar](64) NOT NULL,
	[Cruce2] [varchar](64) NOT NULL,
	[Colonia] [varchar](64) NOT NULL,
	[CP] [varchar](5) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[TelCasa] [varchar](64) NOT NULL,
	[TelOficina] [varchar](50) NOT NULL,
	[Celular] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


