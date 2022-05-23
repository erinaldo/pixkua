CREATE TABLE [Accounting].[VistasContablesImporte](
	[IdVistaContableImporte] [int] IDENTITY(1,1) NOT NULL,
	[IdVistaContableTit] [int] NOT NULL,
	[Columna] [varchar](64) NOT NULL,
	[IdImporte] [int] NOT NULL,
 CONSTRAINT [PK_VistasContablesImporte] PRIMARY KEY CLUSTERED 
(
	[IdVistaContableTit] ASC,
	[Columna] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


