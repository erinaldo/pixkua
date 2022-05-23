CREATE TABLE [Accounting].[EmpresasConfig](
	[IdEmpresa] [int] NOT NULL,
	[BaseDatos] [varchar](100) NOT NULL,
	[IdServicio] [int] NOT NULL,
	[FormatoContable] [varchar](64) NOT NULL,
	[Niveles] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_EmpresasBaseDatos] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


