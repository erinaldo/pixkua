CREATE TABLE [Documents].[AccesoUsuarios](
	[IdAccesoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdTipo] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Aplicar] [bit] NOT NULL,
	[Cancelar] [bit] NOT NULL,
 CONSTRAINT [PK_AccesoUsuarios] PRIMARY KEY NONCLUSTERED 
(
	[IdAccesoUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


