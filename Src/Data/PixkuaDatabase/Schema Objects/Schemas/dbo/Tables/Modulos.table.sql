CREATE TABLE [dbo].[Modulos](
	[IdModulo] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdParent] [int] NOT NULL,
	[IdModuloCategoria] [int] NOT NULL,
	[Modulo] [varchar](32) NOT NULL,
	[Orden] [int] NOT NULL,
	[Path] [varchar](64) NOT NULL,
	[Descr] [varchar](256) NOT NULL,
	[ImageFile] [varchar](64) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


