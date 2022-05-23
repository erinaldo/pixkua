/****** Object:  ForeignKey [FK_AccesoProcesos_Usuarios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[AccesoProcesos]  WITH NOCHECK ADD  CONSTRAINT [FK_AccesoProcesos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[AccesoProcesos] CHECK CONSTRAINT [FK_AccesoProcesos_Usuarios]

