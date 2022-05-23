CREATE TABLE [Purchasing].[RequisicionesTipos](
	[IdRequisicionTipo] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_RequisicionesTipos] PRIMARY KEY CLUSTERED 
(
	[IdRequisicionTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


