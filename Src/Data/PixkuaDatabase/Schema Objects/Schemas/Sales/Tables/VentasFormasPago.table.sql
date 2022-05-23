CREATE TABLE [Sales].[VentasFormasPago](
	[IdVentaFormaPago] [int] IDENTITY(1,1) NOT NULL,
	[IdVentaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdFormaPago] [int] NOT NULL,
	[Monto] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_VentasFormasPago] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdVentaTit] ASC,
	[IdFormaPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


