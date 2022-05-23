CREATE TABLE [Inventory].[MovimientosDet](
	[IdMovimientoDet] [int] IDENTITY(1,1) NOT NULL,
	[IdMovimientoTit] [char](18) NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[CantidadBase] [decimal](19, 4) NOT NULL,
	[CostoUnitario] [decimal](19, 4) NOT NULL,
	[Flete] [decimal](19, 4) NOT NULL,
	[DisponibleInicial] [decimal](19, 4) NOT NULL,
	[DisponibleFinal] [decimal](19, 4) NOT NULL,
	[ApartadoInicial] [decimal](19, 4) NOT NULL,
	[ApartadoFinal] [decimal](19, 4) NOT NULL,
	[TransitoInicial] [decimal](19, 4) NOT NULL,
	[TransitoFinal] [decimal](19, 4) NOT NULL,
	[ExistenciaInicial] [decimal](19, 4) NOT NULL,
	[ExistenciaFinal] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_MovimientosDet] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdMovimientoTit] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


