/****** Object:  ForeignKey [FK_ProveedoresArticulos_ZonasCompra]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresArticulos_ZonasCompra] FOREIGN KEY([IdZonaCompra])
REFERENCES [Purchasing].[ZonasCompra] ([IdZonaCompra])


GO
ALTER TABLE [Purchasing].[ProveedoresArticulos] CHECK CONSTRAINT [FK_ProveedoresArticulos_ZonasCompra]

