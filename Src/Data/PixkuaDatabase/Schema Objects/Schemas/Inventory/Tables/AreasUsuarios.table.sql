﻿CREATE TABLE [Inventory].[AreasUsuarios](
	[IdAreaUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdArea] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_AreasUsuarios] PRIMARY KEY CLUSTERED 
(
	[IdArea] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

