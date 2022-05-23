CREATE TABLE [Sales].[ClientesDomicilios](
	[IdClienteDomicilio] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[TipoDomicilio] [char](1) NOT NULL,
	[Calle] [varchar](128) NOT NULL,
	[Cruce1] [varchar](128) NOT NULL,
	[Cruce2] [varchar](128) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[Colonia] [varchar](128) NOT NULL,
	[CP] [char](5) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[Latitud] [real] NOT NULL,
	[Longitud] [real] NOT NULL,
	[Telefonos] [varchar](64) NOT NULL,
	[Fax] [varchar](16) NOT NULL,
 CONSTRAINT [PK_ClientesDomicilios] PRIMARY KEY CLUSTERED 
(
	[IdClienteDomicilio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica el tipo de domicilio:
F=Facturación
E=Entrega' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'ClientesDomicilios', @level2type=N'COLUMN',@level2name=N'TipoDomicilio'

