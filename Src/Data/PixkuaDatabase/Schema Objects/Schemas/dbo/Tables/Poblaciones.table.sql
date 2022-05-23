CREATE TABLE [dbo].[Poblaciones](
	[IdPoblacion] [int] NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[IdMunicipio] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Poblacion] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Poblaciones] PRIMARY KEY CLUSTERED 
(
	[IdPoblacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


