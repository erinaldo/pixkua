CREATE TABLE [Purchasing].[CFDCertificados](
	[NumSerie] [varchar](32) NOT NULL,
	[FechaInicial] [datetime] NOT NULL,
	[FechaFinal] [datetime] NOT NULL,
	[RFC] [char](13) NOT NULL,
	[Estatus] [char](1) NOT NULL,
 CONSTRAINT [PK_Purchasing_CFDCertificados] PRIMARY KEY CLUSTERED 
(
	[NumSerie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


