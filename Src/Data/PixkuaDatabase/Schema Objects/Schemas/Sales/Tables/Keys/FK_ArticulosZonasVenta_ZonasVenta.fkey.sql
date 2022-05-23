/****** Object:  ForeignKey [FK_ArticulosZonasVenta_ZonasVenta]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ArticulosZonasVenta]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosZonasVenta_ZonasVenta] FOREIGN KEY([IdZonaVenta])
REFERENCES [Sales].[ZonasVenta] ([IdZonaVenta])


GO
ALTER TABLE [Sales].[ArticulosZonasVenta] CHECK CONSTRAINT [FK_ArticulosZonasVenta_ZonasVenta]

