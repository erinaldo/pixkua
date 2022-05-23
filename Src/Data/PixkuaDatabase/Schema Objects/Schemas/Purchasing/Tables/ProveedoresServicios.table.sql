CREATE TABLE [Purchasing].[ProveedoresServicios](
	[IdProveedorServicio] [int] IDENTITY(1,1) NOT NULL,
	[IdServicio] [int] NOT NULL,
	[IdZonaCompra] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[Costo] [decimal](19, 4) NOT NULL,
	[DiasCredito] [int] NOT NULL,
	[DiasEntrega] [int] NOT NULL,
	[IdImpuesto1] [int] NOT NULL,
	[IdImpuesto2] [int] NOT NULL,
	[IdImpuesto3] [int] NOT NULL,
	[IdRetencion1] [int] NOT NULL,
	[IdRetencion2] [int] NOT NULL,
	[IdRetencion3] [int] NOT NULL,
	[PorcDescuento1] [decimal](7, 6) NOT NULL,
	[PorcDescuento2] [decimal](7, 6) NOT NULL,
	[PorcDescuento3] [decimal](7, 6) NOT NULL,
	[Predeterminado] [bit] NOT NULL,
 CONSTRAINT [PK_ProveedoresServicios] PRIMARY KEY CLUSTERED 
(
	[IdServicio] ASC,
	[IdZonaCompra] ASC,
	[IdProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


