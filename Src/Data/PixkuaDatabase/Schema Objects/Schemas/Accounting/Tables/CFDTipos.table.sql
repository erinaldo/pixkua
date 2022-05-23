﻿CREATE TABLE [Accounting].[CFDTipos](
	[IdCFDTipo] [int] NOT NULL,
	[Nombre] [varchar](32) NOT NULL,
	[Efecto] [char](1) NOT NULL,
 CONSTRAINT [PK_CFDTipos] PRIMARY KEY CLUSTERED 
(
	[IdCFDTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

