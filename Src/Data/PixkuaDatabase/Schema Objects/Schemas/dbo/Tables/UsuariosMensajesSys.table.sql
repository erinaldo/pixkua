CREATE TABLE [dbo].[UsuariosMensajesSys](
	[IdUsuarioMensaje] [int] IDENTITY(1,1) NOT NULL,
	[IdMensajeSys] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[ProgramUpdate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_UsuariosMensajesSys] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioMensaje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


