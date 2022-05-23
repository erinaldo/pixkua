﻿CREATE TABLE [dbo].[GruposProcesos](
	[IdGrupoProceso] [int] IDENTITY(1,1) NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[IdProceso] [int] NOT NULL,
	[Acceso] [bit] NOT NULL,
 CONSTRAINT [PK_GruposProcesos] PRIMARY KEY CLUSTERED 
(
	[IdGrupoProceso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


