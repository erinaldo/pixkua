/****** Object:  ForeignKey [FK_VentasDet_Servicios]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasDet]  WITH NOCHECK ADD  CONSTRAINT [FK_VentasDet_Servicios] FOREIGN KEY([IdServicio])
REFERENCES [Sales].[Servicios] ([IdServicio])
NOT FOR REPLICATION


GO
ALTER TABLE [Sales].[VentasDet] NOCHECK CONSTRAINT [FK_VentasDet_Servicios]

