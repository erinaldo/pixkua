CREATE TABLE [Sales].[ArticulosFotos](
	[IdArticuloFoto] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Foto] [image] NOT NULL,
 CONSTRAINT [PK_ArticulosFotos] PRIMARY KEY CLUSTERED 
(
	[IdArticuloFoto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


