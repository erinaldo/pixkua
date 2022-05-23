CREATE TABLE [Accounting].[CFDSeries](
	[IdCFDSerie] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Serie] [char](10) NOT NULL,
	[IdCFDCertificado] [int] NOT NULL,
	[UltimoFolio] [int] NOT NULL,
	[FolioLimite] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_CFDSeries] PRIMARY KEY CLUSTERED 
(
	[IdCFDSerie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


