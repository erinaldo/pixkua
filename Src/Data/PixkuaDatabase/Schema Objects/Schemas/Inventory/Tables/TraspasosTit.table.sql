CREATE TABLE [Inventory].[TraspasosTit](
	[IdTraspasoTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[HoraMovto] [datetime] NULL,
	[HoraApartado] [datetime] NULL,
	[HoraCarga] [datetime] NULL,
	[HoraAplicado] [datetime] NULL,
	[IdConcepto] [int] NOT NULL,
	[IdAlmacenOrigen] [int] NOT NULL,
	[IdAlmacenDestino] [int] NOT NULL,
	[IdMovimientoIN] [char](18) NOT NULL,
	[IdMovimientoOUT] [char](18) NOT NULL,
	[TotalCantidad] [decimal](19, 4) NOT NULL,
	[TotalCosto] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[Referencia] [char](18) NOT NULL,
	[IdCorte] [uniqueidentifier] NOT NULL,
	[Observaciones] [varchar](128) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_TraspasosTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdTraspasoTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


