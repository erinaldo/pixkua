CREATE TABLE [Inventory].[TraspasosDet](
	[IdTraspasoDet] [int] IDENTITY(1,1) NOT NULL,
	[IdTraspasoTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[CantidadEnviada] [decimal](19, 4) NOT NULL,
	[CantidadRecibida] [decimal](19, 4) NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[CostoUnitario] [decimal](19, 4) NOT NULL,
	[Flete] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_TraspasosDet] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdTraspasoTit] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


