CREATE TABLE [Accounting].[CuentasTiposAgrupador](
	[IdCuentaTipoAgrupador] [int] NOT NULL,
	[Descripcion] [varchar](128) NOT NULL,
	[Definicion] [char](1) NOT NULL,
 CONSTRAINT [PK_CuentasTiposAgrupador] PRIMARY KEY CLUSTERED 
(
	[IdCuentaTipoAgrupador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


