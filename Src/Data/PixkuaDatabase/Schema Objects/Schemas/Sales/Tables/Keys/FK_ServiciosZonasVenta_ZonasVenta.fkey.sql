/****** Object:  ForeignKey [FK_ServiciosZonasVenta_ZonasVenta]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ServiciosZonasVenta]  WITH CHECK ADD  CONSTRAINT [FK_ServiciosZonasVenta_ZonasVenta] FOREIGN KEY([IdZonaVenta])
REFERENCES [Sales].[ZonasVenta] ([IdZonaVenta])


GO
ALTER TABLE [Sales].[ServiciosZonasVenta] CHECK CONSTRAINT [FK_ServiciosZonasVenta_ZonasVenta]

