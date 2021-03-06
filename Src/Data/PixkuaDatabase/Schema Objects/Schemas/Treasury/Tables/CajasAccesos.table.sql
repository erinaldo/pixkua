CREATE TABLE [Treasury].[CajasAccesos](
	[IdCajaAccesos] [int] IDENTITY(1,1) NOT NULL,
	[IdCaja] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_CajasAccesos] PRIMARY KEY CLUSTERED 
(
	[IdCaja] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


