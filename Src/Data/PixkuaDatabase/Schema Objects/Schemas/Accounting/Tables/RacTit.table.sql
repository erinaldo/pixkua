CREATE TABLE [Accounting].[RacTit](
	[IdRacTit] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[IdPolizaPerfil] [int] NOT NULL,
	[IdSegmentoNegocio] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_RacTit_Pixkua] PRIMARY KEY CLUSTERED 
(
	[IdRacTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


