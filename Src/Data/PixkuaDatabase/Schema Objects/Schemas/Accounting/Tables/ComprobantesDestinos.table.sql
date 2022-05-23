CREATE TABLE [Accounting].[ComprobantesDestinos](
	[IdComprobanteDestino] [int] NOT NULL,
	[Nombre] [varchar](32) NOT NULL,
	[MetodoEnvio] [char](1) NOT NULL,
	[Address] [varchar](512) NOT NULL,
	[Folder] [varchar](256) NOT NULL,
	[UserName] [varchar](64) NOT NULL,
	[Password] [varchar](32) NOT NULL,
 CONSTRAINT [PK_ComprobantesDestinos] PRIMARY KEY CLUSTERED 
(
	[IdComprobanteDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A=AS2
F=FTP
W=Web Service' , @level0type=N'SCHEMA',@level0name=N'Accounting', @level1type=N'TABLE',@level1name=N'ComprobantesDestinos', @level2type=N'COLUMN',@level2name=N'MetodoEnvio'

