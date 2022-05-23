CREATE TABLE [Accounting].[EjerciciosFiscalesDet](
	[IdEjercicioFiscalDet] [int] IDENTITY(1,1) NOT NULL,
	[IdEjercicioFiscalTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Mes] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_EjerciciosFiscalesDet] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdEjercicioFiscalTit] ASC,
	[Mes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


