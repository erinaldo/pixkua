CREATE TABLE [Accounting].[CFDCertificados](
	[IdCFDCertificado] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[LlavePrivada] [varbinary](2048) NULL,
	[PasswordPK] [varchar](32) NOT NULL,
	[Certificado] [varbinary](2048) NULL,
	[NumCertificado] [char](20) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_CFDCertificados] PRIMARY KEY CLUSTERED 
(
	[IdCFDCertificado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


