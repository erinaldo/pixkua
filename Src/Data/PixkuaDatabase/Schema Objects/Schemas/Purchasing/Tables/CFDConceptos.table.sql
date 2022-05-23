CREATE TABLE [Purchasing].[CFDConceptos](
	[IdCFDConcepto] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Serie] [char](10) NOT NULL,
	[Folio] [int] NOT NULL,
	[UUID] [char](36) NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Descripcion] [varchar](512) NOT NULL,
	[EAN] [varchar](32) NOT NULL,
	[Unidad] [varchar](64) NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[PrecioUnitario] [decimal](19, 4) NOT NULL,
	[FactorUnidad] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[PorcImpTras1] [decimal](7, 6) NOT NULL,
	[PorcImpTras2] [decimal](7, 6) NOT NULL,
	[PorcImpTras3] [decimal](7, 6) NOT NULL,
	[PorcImpRet1] [decimal](7, 6) NOT NULL,
	[PorcImpRet2] [decimal](7, 6) NOT NULL,
	[PorcImpRet3] [decimal](7, 6) NOT NULL,
	[PorcDesc1] [decimal](7, 6) NOT NULL,
	[PorcDesc2] [decimal](7, 6) NOT NULL,
	[PorcDesc3] [decimal](7, 6) NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
 CONSTRAINT [PK_CFDConceptos] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC,
	[Serie] ASC,
	[Folio] ASC,
	[UUID] ASC,
	[Codigo] ASC,
	[Descripcion] ASC,
	[IdCFDConcepto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


