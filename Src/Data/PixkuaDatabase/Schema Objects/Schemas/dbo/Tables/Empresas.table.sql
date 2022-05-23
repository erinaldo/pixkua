CREATE TABLE [dbo].[Empresas](
	[IdEmpresa] [int] NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](32) NOT NULL,
	[NombreLargo] [varchar](64) NOT NULL,
	[Logo] [image] NULL,
	[RFC] [varchar](16) NOT NULL,
	[RazonSocial] [varchar](128) NOT NULL,
	[Calle] [varchar](128) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[Colonia] [varchar](128) NOT NULL,
	[CP] [char](5) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[FormatoContable] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


