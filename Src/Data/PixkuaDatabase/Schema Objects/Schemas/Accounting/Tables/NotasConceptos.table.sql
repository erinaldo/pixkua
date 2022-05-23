﻿CREATE TABLE [Accounting].[NotasConceptos](
	[IdNotaConcepto] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[ConceptoLibre] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_NotasConceptos] PRIMARY KEY CLUSTERED 
(
	[IdNotaConcepto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


