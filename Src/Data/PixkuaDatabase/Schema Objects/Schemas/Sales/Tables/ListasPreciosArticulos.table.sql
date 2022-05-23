CREATE TABLE [Sales].[ListasPreciosArticulos](
	[IdListaPrecioArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdListaPrecio] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_ListasPreciosArticulos_1] PRIMARY KEY CLUSTERED 
(
	[IdListaPrecio] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


