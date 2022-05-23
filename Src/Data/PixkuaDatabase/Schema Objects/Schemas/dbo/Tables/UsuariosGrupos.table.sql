﻿CREATE TABLE [dbo].[UsuariosGrupos](
	[IdUsuarioGrupo] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdGrupo] [int] NOT NULL,
 CONSTRAINT [PK_UsuariosGrupos] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioGrupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


