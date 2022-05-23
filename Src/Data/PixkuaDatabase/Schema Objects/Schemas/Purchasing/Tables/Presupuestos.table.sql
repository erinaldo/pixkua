CREATE TABLE [Purchasing].[Presupuestos](
	[IdPresupuesto] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[MontoPresupuesto] [decimal](19, 4) NOT NULL,
	[MontoUtilizado] [decimal](19, 4) NOT NULL,
	[MontoApartado] [decimal](19, 4) NOT NULL,
	[Estatus] [char](1) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Presupuestos] PRIMARY KEY CLUSTERED 
(
	[IdPresupuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


