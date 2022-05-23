CREATE TABLE [Accounting].[CuentasImportacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](30) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[Tipo] [varchar](3) NOT NULL,
	[Padre] [varchar](30) NOT NULL,
	[SegNeg] [bit] NOT NULL
) ON [PRIMARY]


