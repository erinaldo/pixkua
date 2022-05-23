CREATE TABLE [Accounting].[ContabilizacionDocumentosTit](
	[IdContabilizacionDocumentoTit] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdVistaContableTit] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_AuditoriaDocumentos] PRIMARY KEY NONCLUSTERED 
(
	[IdContabilizacionDocumentoTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


