CREATE TABLE [dbo].[Procesos](
	[IdProceso] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdModulo] [int] NOT NULL,
	[Proceso] [varchar](64) NOT NULL,
	[Descr] [varchar](256) NOT NULL,
	[IdProcesoTipo] [int] NOT NULL,
	[Orden] [int] NOT NULL,
	[ImageFile] [varchar](64) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Procesos] PRIMARY KEY CLUSTERED 
(
	[IdProceso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


