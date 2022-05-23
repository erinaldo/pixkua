CREATE TABLE [dbo].[Formatos](
	[IdFormato] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[Formato] [xml] NOT NULL,
	[DataSourceXSD] [xml] NULL,
 CONSTRAINT [PK_FormatosPrint] PRIMARY KEY NONCLUSTERED 
(
	[IdEmpresa] ASC,
	[IdSucursal] ASC,
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


