CREATE TABLE [Sales].[Cortes](
	[IdCorte] [uniqueidentifier] NOT NULL,
	[IdCaja] [int] NOT NULL,
	[FechaApertura] [datetime] NOT NULL,
	[HoraApertura] [datetime] NOT NULL,
	[FechaCierre] [datetime] NULL,
	[HoraCierre] [datetime] NULL,
	[IdCajero] [int] NOT NULL,
	[IdTurno] [int] NOT NULL,
	[InvLinea] [bit] NOT NULL,
	[InvAfectado] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
 CONSTRAINT [PK_Sales_Cortes] PRIMARY KEY CLUSTERED 
(
	[IdCaja] ASC,
	[FechaApertura] ASC,
	[HoraApertura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


