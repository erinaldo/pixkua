/****** Object:  ForeignKey [FK_UnidadesNegocio_Sucursales]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[UnidadesNegocio]  WITH CHECK ADD  CONSTRAINT [FK_UnidadesNegocio_Sucursales] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursales] ([IdSucursal])


GO
ALTER TABLE [Sales].[UnidadesNegocio] CHECK CONSTRAINT [FK_UnidadesNegocio_Sucursales]

