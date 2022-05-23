CREATE TABLE [Sales].[CambioPreciosArticulosDet](
	[IdCambioPrecioArticulosDet] [int] NOT NULL,
	[IdCambioPreciosArticulosTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_CambioPreciosArticulosDet] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdCambioPreciosArticulosTit] ASC,
	[IdCambioPrecioArticulosDet] ASC,
	[IdArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


