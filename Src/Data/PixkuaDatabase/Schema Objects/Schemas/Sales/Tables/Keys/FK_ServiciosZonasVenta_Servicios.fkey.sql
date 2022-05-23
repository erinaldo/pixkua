/****** Object:  ForeignKey [FK_ServiciosZonasVenta_Servicios]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ServiciosZonasVenta]  WITH CHECK ADD  CONSTRAINT [FK_ServiciosZonasVenta_Servicios] FOREIGN KEY([IdServicio])
REFERENCES [Sales].[Servicios] ([IdServicio])


GO
ALTER TABLE [Sales].[ServiciosZonasVenta] CHECK CONSTRAINT [FK_ServiciosZonasVenta_Servicios]

