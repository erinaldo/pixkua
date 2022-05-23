CREATE TABLE [Accounting].[PolizasAcumuladas](
	[IdPolizaAcumulada] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdPolizaPerfil] [int] NOT NULL,
	[IdPolizaTit] [char](18) NOT NULL,
 CONSTRAINT [PK_PolizasAcumuladas] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdSucursal] ASC,
	[IdPolizaPerfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


