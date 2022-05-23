CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
	[Usuario] [varchar](32) NOT NULL,
	[Password] [varchar](128) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[WorkStation] [varchar](32) NOT NULL,
	[LightUser] [bit] NOT NULL,
	[DomainUser] [varchar](64) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[UserCreate] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


