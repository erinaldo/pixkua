CREATE TABLE [Treasury].[Beneficiarios](
	[IdBeneficiario] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[RazonSocial] [varchar](128) NOT NULL,
	[TipoBeneficiario] [char](1) NOT NULL,
	[IdReferencia] [int] NOT NULL,
	[IdBanco] [int] NOT NULL,
	[CLABE] [char](18) NOT NULL,
	[LeyendaCheque] [bit] NOT NULL,
	[DiasCredito] [int] NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Beneficiarios] PRIMARY KEY CLUSTERED 
(
	[IdBeneficiario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


