CREATE TABLE [Accounting].[Cuentas](
	[IdCuenta] [int] NOT NULL,
	[IdPadre] [int] NOT NULL,
	[Codigo] [varchar](64) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdCuentaTipo] [int] NOT NULL,
	[IdCuentaOrden] [int] NOT NULL,
	[SaldoInicial] [decimal](18, 4) NOT NULL,
	[Cargos] [decimal](18, 4) NOT NULL,
	[Abonos] [decimal](18, 4) NOT NULL,
	[FechaUltMovto] [datetime] NULL,
	[Orden] [int] NOT NULL,
	[Nivel] [int] NOT NULL,
	[Path] [varchar](128) NOT NULL,
	[NamedPath] [varchar](1024) NOT NULL,
	[IsLeaf] [bit] NOT NULL,
	[SegNeg] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Cuentas_Contables] PRIMARY KEY CLUSTERED 
(
	[IdCuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


