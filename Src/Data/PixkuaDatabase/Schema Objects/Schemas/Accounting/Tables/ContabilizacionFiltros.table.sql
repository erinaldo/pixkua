CREATE TABLE [Accounting].[ContabilizacionFiltros](
	[IdContabilizacionFiltro] [int] IDENTITY(1,1) NOT NULL,
	[IdContabilizacionDocumentoDet] [int] NOT NULL,
	[Filtro] [varchar](8000) NOT NULL,
	[IdRacTit] [int] NOT NULL,
 CONSTRAINT [PK_ContabilizacionFiltros] PRIMARY KEY CLUSTERED 
(
	[IdContabilizacionFiltro] ASC,
	[IdContabilizacionDocumentoDet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


