CREATE TABLE [Accounting].[CFDConceptos](
	[FechaComprobante] [datetime] NOT NULL,
	[IdCFDSerie] [int] NOT NULL,
	[Folio] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Descripcion] [varchar](512) NOT NULL,
	[EAN] [varchar](32) NOT NULL,
	[Unidad] [varchar](64) NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[PrecioUnitario] [decimal](19, 4) NOT NULL,
	[PorcImpTras1] [decimal](7, 6) NOT NULL,
	[PorcImpTras2] [decimal](7, 6) NOT NULL,
	[PorcImpTras3] [decimal](7, 6) NOT NULL,
	[PorcImpRet1] [decimal](7, 6) NOT NULL,
	[PorcImpRet2] [decimal](7, 6) NOT NULL,
	[PorcImpRet3] [decimal](7, 6) NOT NULL,
	[PorcDesc1] [decimal](7, 6) NOT NULL,
	[PorcDesc2] [decimal](7, 6) NOT NULL,
	[PorcDesc3] [decimal](7, 6) NOT NULL,
	[PorcDesc4] [decimal](7, 6) NOT NULL,
	[PorcDesc5] [decimal](7, 6) NOT NULL,
	[FactorUnidad] [int] NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
 CONSTRAINT [PK_CFDDetalle] PRIMARY KEY CLUSTERED 
(
	[FechaComprobante] ASC,
	[IdCFDSerie] ASC,
	[Folio] ASC,
	[IdArticulo] ASC,
	[IdServicio] ASC,
	[Codigo] ASC,
	[Descripcion] ASC,
	[IdDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


