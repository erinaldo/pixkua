CREATE TABLE [Purchasing].[CentrosRecepcionAccesos](
	[IdCentroRecepcionAcceso] [int] IDENTITY(1,1) NOT NULL,
	[IdCentroRecepcion] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Acceso] [bit] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_CentrosRecepcionAccesos] PRIMARY KEY CLUSTERED 
(
	[IdCentroRecepcion] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


