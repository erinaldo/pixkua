CREATE TABLE [Accounting].[ContabilizacionDocumentosDet](
	[IdContabilizacionDocumentoDet] [int] IDENTITY(1,1) NOT NULL,
	[IdContabilizacionDocumentoTit] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Variante] [bit] NOT NULL,
	[IdRacTit] [int] NOT NULL,
	[Pivote] [varchar](8000) NOT NULL,
 CONSTRAINT [PK_ContabilizacionDocumentosDet] PRIMARY KEY CLUSTERED 
(
	[IdContabilizacionDocumentoTit] ASC,
	[IdStatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


