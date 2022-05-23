CREATE TABLE [dbo].[UsuariosSucursales](
	[IdUsuarioSucursal] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Acceso] [bit] NOT NULL,
 CONSTRAINT [PK_UsuariosSucursales] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


