CREATE TABLE [dbo].[Operadores](
	[IdOperador] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[EnvioCorreo] [bit] NOT NULL,
	[Correo] [varchar](512) NOT NULL,
	[EnvioSMS] [bit] NOT NULL,
	[NumeroCelular] [varchar](32) NOT NULL,
	[IdOperadorCelular] [int] NOT NULL,
	[EnvioNetSend] [bit] NOT NULL,
	[DireccionIP] [varchar](32) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Operadores] PRIMARY KEY CLUSTERED 
(
	[IdOperador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


