CREATE TABLE [Accounting].[Kardex](
	[IdKardex] [int] IDENTITY(1,1) NOT NULL,
	[IdPolizaTit] [varchar](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdPolizaDet] [int] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[CargoInicial] [decimal](18, 4) NOT NULL,
	[AbonoInicial] [decimal](18, 4) NOT NULL,
	[Cargo] [decimal](18, 4) NOT NULL,
	[Abono] [decimal](18, 4) NOT NULL,
	[CargoFinal] [decimal](18, 4) NOT NULL,
	[AbonoFinal] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Kardex] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdPolizaTit] ASC,
	[IdPolizaDet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


