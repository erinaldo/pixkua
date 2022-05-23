CREATE TABLE [Accounting].[CuentasSaldos](
	[IdCuentaSaldo] [int] IDENTITY(1,1) NOT NULL,
	[IdEjercicioFiscalTit] [char](18) NOT NULL,
	[Mes] [int] NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[Cargos] [decimal](18, 4) NOT NULL,
	[Abonos] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_CuentasSaldos] PRIMARY KEY CLUSTERED 
(
	[IdEjercicioFiscalTit] ASC,
	[Mes] ASC,
	[IdCuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


