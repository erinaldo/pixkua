CREATE TABLE [Accounting].[PolizasPerfiles](
	[IdPolizaPerfil] [int] NOT NULL,
	[Codigo] [varchar](1) NOT NULL,
	[Descripcion] [varchar](64) NOT NULL,
	[IdPolizaOrigen] [int] NOT NULL,
	[IdPolizaTipo] [int] NOT NULL,
	[IdPolizaSumarizacion] [int] NOT NULL,
	[Acumulable] [bit] NOT NULL,
	[AfectarSistemaExterno] [bit] NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdVistaContableTit] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime2](7) NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Polizas] PRIMARY KEY CLUSTERED 
(
	[IdPolizaPerfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Este tipo de documento es para q la Poliza siga un workflow' , @level0type=N'SCHEMA',@level0name=N'Accounting', @level1type=N'TABLE',@level1name=N'PolizasPerfiles', @level2type=N'COLUMN',@level2name=N'IdDocumentoTipo'

