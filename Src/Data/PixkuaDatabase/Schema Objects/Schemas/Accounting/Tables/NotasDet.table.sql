CREATE TABLE [Accounting].[NotasDet](
	[IdNotaDet] [int] IDENTITY(1,1) NOT NULL,
	[IdNotaTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdNotaConcepto] [int] NOT NULL,
	[Concepto] [varchar](128) NOT NULL,
	[Monto] [decimal](19, 4) NOT NULL,
	[IdImpuestoTras1] [int] NOT NULL,
	[IdImpuestoTras2] [int] NOT NULL,
	[IdImpuestoTras3] [int] NOT NULL,
	[PorcImpTras1] [decimal](7, 6) NOT NULL,
	[PorcImpTras2] [decimal](7, 6) NOT NULL,
	[PorcImpTras3] [decimal](7, 6) NOT NULL,
	[MontoImpTras1] [decimal](19, 4) NOT NULL,
	[MontoImpTras2] [decimal](19, 4) NOT NULL,
	[MontoImpTras3] [decimal](19, 4) NOT NULL,
	[IdImpuestoRet1] [int] NOT NULL,
	[IdImpuestoRet2] [int] NOT NULL,
	[IdImpuestoRet3] [int] NOT NULL,
	[PorcImpRet1] [decimal](7, 6) NOT NULL,
	[PorcImpRet2] [decimal](7, 6) NOT NULL,
	[PorcImpRet3] [decimal](7, 6) NOT NULL,
	[MontoImpRet1] [decimal](19, 4) NOT NULL,
	[MontoImpRet2] [decimal](19, 4) NOT NULL,
	[MontoImpRet3] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_NotasDet] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdNotaTit] ASC,
	[IdNotaConcepto] ASC,
	[IdNotaDet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


