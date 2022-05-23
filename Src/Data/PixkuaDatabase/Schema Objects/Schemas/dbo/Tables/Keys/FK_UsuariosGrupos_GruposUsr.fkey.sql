/****** Object:  ForeignKey [FK_UsuariosGrupos_GruposUsr]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosGrupos]  WITH NOCHECK ADD  CONSTRAINT [FK_UsuariosGrupos_GruposUsr] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[GruposUsr] ([IdGrupo])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[UsuariosGrupos] CHECK CONSTRAINT [FK_UsuariosGrupos_GruposUsr]

