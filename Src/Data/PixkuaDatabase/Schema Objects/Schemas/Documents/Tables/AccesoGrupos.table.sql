CREATE TABLE [Documents].[AccesoGrupos](
	[IdAccesoGrupo] [int] IDENTITY(1,1) NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[IdTipo] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Aplicar] [bit] NOT NULL,
	[Cancelar] [bit] NOT NULL,
 CONSTRAINT [PK_AccesoGrupos] PRIMARY KEY NONCLUSTERED 
(
	[IdAccesoGrupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


