CREATE TABLE [Restaurant].[ComandaTit](
	[IdComandaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[HoraInicio] [datetime] NOT NULL,
	[IdMesero] [int] NOT NULL,
	[IdMesa] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdRepartidor] [int] NOT NULL,
	[Observaciones] [varchar](128) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_ComandaTit] PRIMARY KEY CLUSTERED 
(
	[IdComandaTit] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


