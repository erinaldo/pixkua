CREATE TABLE [Sales].[ClientesContactos](
	[IdClienteContacto] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
 CONSTRAINT [PK_ClientesContactos] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC,
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


