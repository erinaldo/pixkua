CREATE TABLE [Accounting].[CFDFolios](
	[IdCFDFolio] [int] IDENTITY(1,1) NOT NULL,
	[IdCFDSerie] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NumAprobacion] [int] NOT NULL,
	[AnioAprobacion] [int] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[FolioInicial] [int] NOT NULL,
	[FolioFinal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_CFDFolios_1] PRIMARY KEY CLUSTERED 
(
	[IdCFDSerie] ASC,
	[Fecha] ASC,
	[NumAprobacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


