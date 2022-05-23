/****** Object:  ForeignKey [FK_VentasDet_ArticulosStock]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasDet]  WITH NOCHECK ADD  CONSTRAINT [FK_VentasDet_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])
NOT FOR REPLICATION


GO
ALTER TABLE [Sales].[VentasDet] NOCHECK CONSTRAINT [FK_VentasDet_ArticulosStock]

