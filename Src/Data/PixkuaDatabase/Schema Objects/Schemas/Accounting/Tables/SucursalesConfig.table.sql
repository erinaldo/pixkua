CREATE TABLE [Accounting].[SucursalesConfig](
	[IdSucursal] [int] NOT NULL,
	[IdSerieNotasCargo] [int] NOT NULL,
	[IdSerieNotasCredito] [int] NOT NULL,
	[IdFormatoNotaCargo] [int] NOT NULL,
	[IdFormatoNotaCredito] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_SucursalesConfig] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


