/****** Object:  ForeignKey [FK_ProveedoresServicios_ZonasCompra]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresServicios]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresServicios_ZonasCompra] FOREIGN KEY([IdZonaCompra])
REFERENCES [Purchasing].[ZonasCompra] ([IdZonaCompra])


GO
ALTER TABLE [Purchasing].[ProveedoresServicios] CHECK CONSTRAINT [FK_ProveedoresServicios_ZonasCompra]

