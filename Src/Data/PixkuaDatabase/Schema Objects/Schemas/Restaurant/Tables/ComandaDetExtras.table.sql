CREATE TABLE [Restaurant].[ComandaDetExtras](
	[IdComandaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Partida] [int] NOT NULL,
	[IdInsumo] [int] NOT NULL,
 CONSTRAINT [PK_ComandaDetExtras] PRIMARY KEY CLUSTERED 
(
	[IdComandaTit] ASC,
	[Fecha] ASC,
	[IdArticulo] ASC,
	[Partida] ASC,
	[IdInsumo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


