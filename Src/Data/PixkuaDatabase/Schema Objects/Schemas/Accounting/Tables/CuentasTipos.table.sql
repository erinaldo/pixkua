CREATE TABLE [Accounting].[CuentasTipos](
	[IdCuentaTipo] [int] NOT NULL,
	[CuentaTipo] [varchar](64) NOT NULL,
	[Abrev] [char](1) NOT NULL,
	[Naturaleza] [char](1) NOT NULL,
	[IdCuentaTipoAgrupador] [int] NOT NULL,
 CONSTRAINT [PK_CuentaTipo] PRIMARY KEY CLUSTERED 
(
	[IdCuentaTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


