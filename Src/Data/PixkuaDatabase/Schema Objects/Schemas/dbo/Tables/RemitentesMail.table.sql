CREATE TABLE [dbo].[RemitentesMail](
	[IdRemitenteMail] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[MailAddress] [varchar](128) NOT NULL,
	[UserName] [varchar](128) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[IdServidorSMTP] [int] NOT NULL,
	[OverrideSMTPAuth] [bit] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_RemitentesMail] PRIMARY KEY CLUSTERED 
(
	[IdRemitenteMail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


