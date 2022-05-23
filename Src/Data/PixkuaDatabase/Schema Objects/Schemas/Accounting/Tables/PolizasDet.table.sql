CREATE TABLE [Accounting].[PolizasDet](
	[IdPolizaDet] [int] IDENTITY(1,1) NOT NULL,
	[IdPolizaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdVistaContableTit] [int] NOT NULL,
	[IdReferencia] [char](18) NOT NULL,
	[Referencia] [varchar](32) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[Observaciones] [varchar](100) NOT NULL,
	[Cargo] [decimal](18, 4) NOT NULL,
	[Abono] [decimal](18, 4) NOT NULL,
	[Orden] [smallint] NOT NULL,
	[IdSegmento] [int] NOT NULL,
 CONSTRAINT [PK_PolizasDet] PRIMARY KEY NONCLUSTERED 
(
	[IdPolizaDet] ASC,
	[IdPolizaTit] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


