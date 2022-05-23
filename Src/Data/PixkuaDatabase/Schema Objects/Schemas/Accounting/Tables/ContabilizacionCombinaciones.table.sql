CREATE TABLE [Accounting].[ContabilizacionCombinaciones](
	[IdContabilizacionCombinacion] [int] IDENTITY(1,1) NOT NULL,
	[IdContabilizacionDocumentoDet] [int] NOT NULL,
	[IdEntidad] [varchar](64) NOT NULL,
	[SoloCatalogoSucursal] [bit] NOT NULL,
 CONSTRAINT [PK_ContabilizacionCombinaciones] PRIMARY KEY CLUSTERED 
(
	[IdContabilizacionDocumentoDet] ASC,
	[IdEntidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


