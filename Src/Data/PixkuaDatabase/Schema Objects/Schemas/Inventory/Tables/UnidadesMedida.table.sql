CREATE TABLE [Inventory].[UnidadesMedida](
	[IdUnidadMedida] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](32) NOT NULL,
	[Abreviatura] [varchar](16) NOT NULL,
	[IdUnidadMedidaTipo] [int] NOT NULL,
	[Base] [bit] NOT NULL,
	[Factor] [decimal](19, 4) NOT NULL,
	[Fraccionable] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_UnidadesMedida] PRIMARY KEY CLUSTERED 
(
	[IdUnidadMedida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


