CREATE TABLE [Sales].[PromocionesArticulos](
	[IdPromocionArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdPromocion] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[Operador] [char](2) NOT NULL,
	[BoolOp] [varchar](3) NOT NULL,
	[Excluir] [bit] NOT NULL,
	[IdPromoTipoSalida] [int] NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
	[Descuento] [decimal](7, 6) NOT NULL,
	[IdArticuloCambio] [int] NOT NULL,
	[LimiteMaximo] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_PromocionesArticulos] PRIMARY KEY CLUSTERED 
(
	[IdPromocion] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


