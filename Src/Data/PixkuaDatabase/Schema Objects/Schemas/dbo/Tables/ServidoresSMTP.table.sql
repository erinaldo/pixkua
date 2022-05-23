CREATE TABLE [dbo].[ServidoresSMTP](
	[IdServidorSMTP] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[HostName] [varchar](128) NOT NULL,
	[Port] [int] NOT NULL,
	[UserName] [varchar](128) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[AuthMethod] [varchar](32) NOT NULL,
	[LoginDomain] [varchar](64) NOT NULL,
	[SSL] [bit] NOT NULL,
	[CloseConnection] [bit] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_ServidoresSMTP] PRIMARY KEY CLUSTERED 
(
	[IdServidorSMTP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


