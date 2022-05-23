CREATE TABLE [Sales].[CambioPreciosArticulosTit](
	[IdCambioPrecioArticulosTit] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[FechaActivacion] [datetime] NOT NULL,
	[IdListaPrecios] [int] NOT NULL,
	[Observaciones] [varchar](128) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_CambioPreciosArticulosTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdCambioPrecioArticulosTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


