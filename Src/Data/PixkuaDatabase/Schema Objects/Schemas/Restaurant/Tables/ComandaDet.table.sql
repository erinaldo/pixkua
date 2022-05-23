CREATE TABLE [Restaurant].[ComandaDet](
	[IdComandaDet] [int] IDENTITY(1,1) NOT NULL,
	[IdComandaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdCentroProduccion] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [decimal](18, 4) NOT NULL,
	[Entregado] [decimal](18, 4) NOT NULL,
	[PrecioUnitario] [decimal](18, 4) NOT NULL,
	[Observaciones] [varchar](128) NOT NULL,
	[IdImpuesto1] [int] NOT NULL,
	[IdImpuesto2] [int] NOT NULL,
	[IdImpuesto3] [int] NOT NULL,
	[PorcImpto1] [decimal](18, 4) NOT NULL,
	[PorcImpto2] [decimal](18, 4) NOT NULL,
	[PorcImpto3] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_ComandaDet] PRIMARY KEY CLUSTERED 
(
	[IdComandaTit] ASC,
	[Fecha] ASC,
	[IdCentroProduccion] ASC,
	[IdArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


