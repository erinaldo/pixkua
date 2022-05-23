CREATE TABLE [Accounting].[VistasContablesTit](
	[IdVistaContableTit] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Descripcion] [varchar](64) NOT NULL,
	[Schema] [varchar](64) NOT NULL,
	[Objeto] [varchar](64) NOT NULL,
	[IdObjeto] [varchar](64) NOT NULL,
	[Referencia] [varchar](64) NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_VistasContablesTit] PRIMARY KEY CLUSTERED 
(
	[IdVistaContableTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


