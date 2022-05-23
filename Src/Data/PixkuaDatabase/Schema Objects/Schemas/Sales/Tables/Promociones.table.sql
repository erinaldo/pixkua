CREATE TABLE [Sales].[Promociones](
	[IdPromocion] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdPromoTipoSalida] [int] NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
	[Descuento] [decimal](7, 6) NOT NULL,
	[IdArticuloRegalo] [int] NOT NULL,
	[CantRegalo] [int] NOT NULL,
	[CondicionCantTotal] [bit] NOT NULL,
	[CantidadTotal] [decimal](19, 4) NOT NULL,
	[TipoCondTotal] [char](1) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Promociones] PRIMARY KEY CLUSTERED 
(
	[IdPromocion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica el tipo de condición total.
B = Indica que solo se sumarán los articulos base.
O = Indica que solo se sumarán los artículos opcionales.
C = Indica que se sumarán todos los articulos: bases y opcionales.
' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Promociones', @level2type=N'COLUMN',@level2name=N'TipoCondTotal'

