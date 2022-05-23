CREATE TABLE [Accounting].[Entidades](
	[IdEntidad] [int] NOT NULL,
	[Codigo] [varchar](1) NOT NULL,
	[Entidad] [varchar](64) NOT NULL,
	[Schema] [varchar](64) NOT NULL,
	[Objeto] [varchar](64) NOT NULL,
	[Alias] [varchar](8) NOT NULL,
	[CampoPK] [varchar](32) NOT NULL,
	[CampoName] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Entidades] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


