CREATE TABLE [Accounting].[PolizasFolios](
	[IdPolizaFolio] [int] IDENTITY(1,1) NOT NULL,
	[IdPolizaTipo] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UltimoFolio] [int] NOT NULL,
 CONSTRAINT [PK_PolizasFolios] PRIMARY KEY CLUSTERED 
(
	[IdPolizaTipo] ASC,
	[IdSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


