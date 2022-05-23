/****** Object:  Default [DF_UsuariosMensajesSys_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosMensajesSys] ADD  CONSTRAINT [DF_UsuariosMensajesSys_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


