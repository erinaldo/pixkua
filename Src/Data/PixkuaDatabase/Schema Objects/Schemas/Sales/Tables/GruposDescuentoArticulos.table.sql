CREATE TABLE [Sales].[GruposDescuentoArticulos](
	[IdGrupoDescuentoArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdGrupoDescuento] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[PorcDescuento1] [decimal](7, 6) NOT NULL,
	[PorcDescuento2] [decimal](7, 6) NOT NULL,
	[PorcDescuento3] [decimal](7, 6) NOT NULL,
	[PorcDescuento4] [decimal](7, 6) NOT NULL,
	[PorcDescuento5] [decimal](7, 6) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_GruposDescuentoArticulos_1] PRIMARY KEY CLUSTERED 
(
	[IdGrupoDescuento] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


