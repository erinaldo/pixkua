/****** Object:  ForeignKey [FK_UsuariosSucursales_Sucursales]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[UsuariosSucursales]  WITH NOCHECK ADD  CONSTRAINT [FK_UsuariosSucursales_Sucursales] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursales] ([IdSucursal])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[UsuariosSucursales] CHECK CONSTRAINT [FK_UsuariosSucursales_Sucursales]

