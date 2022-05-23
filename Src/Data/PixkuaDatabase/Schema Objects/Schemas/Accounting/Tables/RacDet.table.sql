CREATE TABLE [Accounting].[RacDet](
	[IdRacDet] [int] IDENTITY(1,1) NOT NULL,
	[IdRacTit] [int] NOT NULL,
	[IdCuenta] [int] NULL,
	[IdEntidad] [int] NULL,
	[CampoFK] [varchar](32) NULL,
	[isEntidadConcepto] [bit] NOT NULL,
	[Afectador] [char](1) NOT NULL,
	[Rojo] [bit] NOT NULL,
	[IdImporte] [int] NOT NULL,
	[Orden] [int] NOT NULL,
	[TotalizarConReferencia] [bit] NOT NULL,
 CONSTRAINT [PK_RacDet_Pixkua_1] PRIMARY KEY CLUSTERED 
(
	[IdRacDet] ASC,
	[IdRacTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


