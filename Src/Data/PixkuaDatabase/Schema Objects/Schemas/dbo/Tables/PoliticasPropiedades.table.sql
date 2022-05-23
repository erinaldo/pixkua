CREATE TABLE [dbo].[PoliticasPropiedades](
	[IdPoliticaPropiedad] [int] IDENTITY(1,1) NOT NULL,
	[IdPolitica] [int] NOT NULL,
	[IdPropiedadControl] [int] NOT NULL,
	[Valor] [varchar](64) NOT NULL,
 CONSTRAINT [PK_PoliticasPropiedades] PRIMARY KEY CLUSTERED 
(
	[IdPoliticaPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


