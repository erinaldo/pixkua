CREATE TABLE [Accounting].[CentrosCostos](
	[IdCentroCostos] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[Tipo] [char](2) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_CentrosCostos_1] PRIMARY KEY CLUSTERED 
(
	[IdCentroCostos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica el tipo de centro de costos:
DI=Directos
IG=Indirectos Generales
IA=Indirectos a nivel área productiva' , @level0type=N'SCHEMA',@level0name=N'Accounting', @level1type=N'TABLE',@level1name=N'CentrosCostos', @level2type=N'COLUMN',@level2name=N'Tipo'

