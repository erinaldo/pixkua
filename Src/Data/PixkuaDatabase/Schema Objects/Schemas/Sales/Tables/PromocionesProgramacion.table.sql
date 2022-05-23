CREATE TABLE [Sales].[PromocionesProgramacion](
	[IdPromocionProgramacion] [int] IDENTITY(1,1) NOT NULL,
	[IdPromocion] [int] NOT NULL,
	[TipoPeriodo] [char](1) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[FechaInicial] [datetime] NOT NULL,
	[FechaFinal] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_PromocionesProgramacion] PRIMARY KEY CLUSTERED 
(
	[IdPromocion] ASC,
	[TipoPeriodo] ASC,
	[IdSucursal] ASC,
	[FechaInicial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


