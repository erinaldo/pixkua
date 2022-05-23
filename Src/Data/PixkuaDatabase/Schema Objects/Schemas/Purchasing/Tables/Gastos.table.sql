CREATE TABLE [Purchasing].[Gastos](
	[IdGasto] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdGastoConcepto] [int] NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[IdPresupuesto] [int] NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[ModalidadPago] [char](1) NOT NULL,
	[IdBeneficiario] [int] NOT NULL,
	[TipoBeneficiario] [char](1) NOT NULL,
	[Notas] [varchar](128) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[SerieFactura] [char](10) NOT NULL,
	[FolioFactura] [int] NOT NULL,
	[AnioAprobacion] [int] NOT NULL,
	[NumAprobacion] [int] NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[IdImpuesto1] [int] NOT NULL,
	[IdImpuesto2] [int] NOT NULL,
	[IdImpuesto3] [int] NOT NULL,
	[PorcImp1] [decimal](7, 6) NOT NULL,
	[PorcImp2] [decimal](7, 6) NOT NULL,
	[PorcImp3] [decimal](7, 6) NOT NULL,
	[MontoImp1] [decimal](19, 4) NOT NULL,
	[MontoImp2] [decimal](19, 4) NOT NULL,
	[MontoImp3] [decimal](19, 4) NOT NULL,
	[IdRetencion1] [int] NOT NULL,
	[IdRetencion2] [int] NOT NULL,
	[IdRetencion3] [int] NOT NULL,
	[PorcRetencion1] [decimal](7, 6) NOT NULL,
	[PorcRetencion2] [decimal](7, 6) NOT NULL,
	[PorcRetencion3] [decimal](7, 6) NOT NULL,
	[MontoRetencion1] [decimal](19, 4) NOT NULL,
	[MontoRetencion2] [decimal](19, 4) NOT NULL,
	[MontoRetencion3] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Gastos] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdGasto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si es un gasto a comprobar (C) o una reposición (R)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Gastos', @level2type=N'COLUMN',@level2name=N'ModalidadPago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica el tipo de beneficiario:
P=Proveedor
E=Cliente
B=Otro beneficiario (tabla de beneficiarios)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Gastos', @level2type=N'COLUMN',@level2name=N'TipoBeneficiario'

