CREATE TABLE [Purchasing].[ProveedoresContactos](
	[IdProveedorContacto] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
 CONSTRAINT [PK_ProveedoresContactos] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC,
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


