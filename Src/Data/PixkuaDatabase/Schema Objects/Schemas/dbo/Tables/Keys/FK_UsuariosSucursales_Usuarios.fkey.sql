/****** Object:  ForeignKey [FK_UsuariosSucursales_Usuarios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosSucursales]  WITH NOCHECK ADD  CONSTRAINT [FK_UsuariosSucursales_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[UsuariosSucursales] CHECK CONSTRAINT [FK_UsuariosSucursales_Usuarios]

