/****** Object:  ForeignKey [FK_UsuariosGrupos_Usuarios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosGrupos]  WITH NOCHECK ADD  CONSTRAINT [FK_UsuariosGrupos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[UsuariosGrupos] CHECK CONSTRAINT [FK_UsuariosGrupos_Usuarios]

