/****** Object:  ForeignKey [FK_ArticulosZonasVenta_Articulos]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ArticulosZonasVenta]  WITH NOCHECK ADD  CONSTRAINT [FK_ArticulosZonasVenta_Articulos] FOREIGN KEY([IdArticuloStock])
REFERENCES [Sales].[Articulos] ([IdArticulo])
NOT FOR REPLICATION


GO
ALTER TABLE [Sales].[ArticulosZonasVenta] NOCHECK CONSTRAINT [FK_ArticulosZonasVenta_Articulos]

