CREATE TABLE [Accounting].[PolizasLog](
	[IdPolizaLog] [int] IDENTITY(1,1) NOT NULL,
	[IdPolizaTit] [varchar](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[FechaLog] [datetime] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Mensaje] [varchar](512) NOT NULL,
 CONSTRAINT [PK_PolizaLog] PRIMARY KEY CLUSTERED 
(
	[IdPolizaLog] ASC,
	[IdPolizaTit] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


