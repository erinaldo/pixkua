CREATE TABLE [Purchasing].[Kardex](
	[IdKardex] [int] IDENTITY(1,1) NOT NULL,
	[IdPresupuesto] [int] NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[IdDocumento] [char](18) NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[Monto] [decimal](19, 4) NOT NULL,
	[MontoUtilizadoIni] [decimal](19, 4) NOT NULL,
	[MontoUtilizadoFin] [decimal](19, 4) NOT NULL,
	[MontoApartadoIni] [decimal](19, 4) NOT NULL,
	[MontoApartadoFin] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_Kardex_2] PRIMARY KEY CLUSTERED 
(
	[IdPresupuesto] ASC,
	[IdCategoriaPresupuestal] ASC,
	[IdDocumento] ASC,
	[FechaDocumento] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


