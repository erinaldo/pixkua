/****** Object:  ForeignKey [FK_AccesoPoliticas_Usuarios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[AccesoPoliticas]  WITH NOCHECK ADD  CONSTRAINT [FK_AccesoPoliticas_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])


GO
ALTER TABLE [dbo].[AccesoPoliticas] CHECK CONSTRAINT [FK_AccesoPoliticas_Usuarios]

