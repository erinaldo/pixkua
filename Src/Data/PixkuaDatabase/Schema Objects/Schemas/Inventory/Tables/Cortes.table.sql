CREATE TABLE [Inventory].[Cortes](
	[IdCorte] [uniqueidentifier] NOT NULL,
	[IdArea] [int] NOT NULL,
	[IdTurno] [int] NOT NULL,
	[FechaApertura] [datetime] NOT NULL,
	[HoraApertura] [datetime] NOT NULL,
	[FechaCierre] [datetime] NULL,
	[HoraCierre] [datetime] NULL,
	[IdUsuarioApertura] [int] NOT NULL,
	[IdUsuarioCierre] [int] NOT NULL,
 CONSTRAINT [PK_Inventory_Cortes] PRIMARY KEY CLUSTERED 
(
	[IdArea] ASC,
	[IdTurno] ASC,
	[FechaApertura] ASC,
	[HoraApertura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


