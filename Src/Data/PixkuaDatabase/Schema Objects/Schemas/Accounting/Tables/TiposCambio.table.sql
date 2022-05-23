CREATE TABLE [Accounting].[TiposCambio](
	[IdTipoCambio] [int] IDENTITY(1,1) NOT NULL,
	[IdDivisaOrigen] [int] NOT NULL,
	[IdDivisaDestino] [int] NOT NULL,
	[PrecioCompra] [decimal](19, 4) NOT NULL,
	[PrecioVenta] [decimal](19, 4) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_TiposCambio] PRIMARY KEY CLUSTERED 
(
	[IdDivisaOrigen] ASC,
	[IdDivisaDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


