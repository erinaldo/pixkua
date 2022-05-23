CREATE TABLE [Sales].[PromocionesClientes](
	[IdPromocionCliente] [int] IDENTITY(1,1) NOT NULL,
	[IdPromocion] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Campo] [varchar](64) NOT NULL,
	[Valor] [int] NOT NULL,
	[Excluir] [bit] NOT NULL,
 CONSTRAINT [PK_PromocionesClientes] PRIMARY KEY CLUSTERED 
(
	[IdPromocion] ASC,
	[IdSucursal] ASC,
	[Campo] ASC,
	[Valor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


