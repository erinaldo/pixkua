/****** Object:  ForeignKey [FK_AccesoUsuarios_Usuarios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[AccesoUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_AccesoUsuarios_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
ON DELETE CASCADE


GO
ALTER TABLE [Documents].[AccesoUsuarios] CHECK CONSTRAINT [FK_AccesoUsuarios_Usuarios]

