CREATE TABLE [Documents].[Folios](
	[IdFolio] [int] IDENTITY(1,1) NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UltimoFolio] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Folios] PRIMARY KEY NONCLUSTERED 
(
	[IdFolio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


