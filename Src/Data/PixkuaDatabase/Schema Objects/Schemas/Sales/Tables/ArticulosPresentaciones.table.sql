CREATE TABLE [Sales].[ArticulosPresentaciones](
	[IdArticuloPresentacion] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
 CONSTRAINT [PK_ArticulosPresentaciones] PRIMARY KEY CLUSTERED 
(
	[IdArticuloStock] ASC,
	[IdArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


