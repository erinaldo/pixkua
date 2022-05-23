CREATE TABLE [Documents].[DocumentosDet](
	[IdDocumentoTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Cantidad] [decimal](19, 4) NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
	[Costo] [decimal](19, 4) NOT NULL,
	[IdImpuestoC1] [int] NOT NULL,
	[IdImpuestoC2] [int] NOT NULL,
	[IdImpuestoC3] [int] NOT NULL,
	[PorcImpC1] [decimal](7, 4) NOT NULL,
	[PorcImpC2] [decimal](7, 4) NOT NULL,
	[PorcImpC3] [decimal](7, 4) NOT NULL,
	[MontoImpC1] [decimal](19, 4) NOT NULL,
	[MontoImpC2] [decimal](19, 4) NOT NULL,
	[MontoImpC3] [decimal](19, 4) NOT NULL,
	[PorcDescuento1] [decimal](7, 4) NOT NULL,
	[PorcDescuento2] [decimal](7, 4) NOT NULL,
	[MontoDesc1] [decimal](19, 4) NOT NULL,
	[MontoDesc2] [decimal](19, 4) NOT NULL,
	[IdImpuestoV1] [int] NOT NULL,
	[IdImpuestoV2] [int] NOT NULL,
	[IdImpuestoV3] [int] NOT NULL,
	[PorcImpV1] [decimal](7, 4) NOT NULL,
	[PorcImpV2] [decimal](7, 4) NOT NULL,
	[PorcImpV3] [decimal](7, 4) NOT NULL,
	[MontoImpV1] [decimal](19, 4) NOT NULL,
	[MontoImpV2] [decimal](19, 4) NOT NULL,
	[MontoImpV3] [decimal](19, 4) NOT NULL,
	[Flete] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_DocumentosDet] PRIMARY KEY CLUSTERED 
(
	[IdDocumentoTit] ASC,
	[Fecha] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


