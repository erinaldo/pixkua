CREATE TABLE [Purchasing].[CFDFolios](
	[RFC] [char](13) NOT NULL,
	[NumAprobacion] [int] NOT NULL,
	[AnioAprobacion] [int] NOT NULL,
	[Serie] [char](10) NOT NULL,
	[FolioInicial] [int] NOT NULL,
	[FolioFinal] [int] NOT NULL,
	[FechaTransaccion] [datetime] NULL,
 CONSTRAINT [PK__Purchasing_CFDFolios] PRIMARY KEY CLUSTERED 
(
	[RFC] ASC,
	[Serie] ASC,
	[FolioFinal] ASC,
	[FolioInicial] ASC,
	[AnioAprobacion] ASC,
	[NumAprobacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


