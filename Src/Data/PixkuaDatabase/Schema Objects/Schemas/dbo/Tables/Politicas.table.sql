CREATE TABLE [dbo].[Politicas](
	[IdPolitica] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdProcesoForma] [int] NOT NULL,
	[Politica] [varchar](64) NOT NULL,
	[Descripcion] [varchar](256) NOT NULL,
	[IdPoliticaTipo] [int] NOT NULL,
	[Control] [varchar](64) NOT NULL,
	[Comportamiento] [char](1) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Politicas] PRIMARY KEY CLUSTERED 
(
	[IdPolitica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica la forma en que se comportará la política:
T=Aplicara para Todos los Usuarios
E=Aplicar sólo para los usuarios especificados.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Politicas', @level2type=N'COLUMN',@level2name=N'Comportamiento'

