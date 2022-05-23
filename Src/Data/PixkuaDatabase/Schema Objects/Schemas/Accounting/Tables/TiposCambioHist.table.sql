CREATE TABLE [Accounting].[TiposCambioHist](
	[IdTipoCambioHist] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdDivisaOrigen] [int] NOT NULL,
	[IdDivisaDestino] [int] NOT NULL,
	[PrecioCompra] [decimal](19, 4) NOT NULL,
	[PrecioVenta] [decimal](19, 4) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_TiposCambioHist] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdDivisaOrigen] ASC,
	[IdDivisaDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


