/****** Object:  Default [DF_UsuariosMensajesSys_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosMensajesSys] ADD  CONSTRAINT [DF_UsuariosMensajesSys_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


