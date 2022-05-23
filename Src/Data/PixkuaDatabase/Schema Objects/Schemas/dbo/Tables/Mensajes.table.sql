CREATE TABLE [dbo].[Mensajes](
	[IdMensaje] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[IdSucursal] [uniqueidentifier] NOT NULL,
	[Asunto] [varchar](64) NOT NULL,
	[Mensaje] [varchar](1024) NOT NULL,
	[IdRemitente] [uniqueidentifier] NOT NULL,
	[IdDestinatario] [uniqueidentifier] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[Nuevo] [bit] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Mensajes] PRIMARY KEY CLUSTERED 
(
	[IdMensaje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


