/****** Object:  ForeignKey [FK_GruposDescuentoArticulos_Articulos]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[GruposDescuentoArticulos]  WITH NOCHECK ADD  CONSTRAINT [FK_GruposDescuentoArticulos_Articulos] FOREIGN KEY([IdArticuloStock])
REFERENCES [Sales].[Articulos] ([IdArticulo])
NOT FOR REPLICATION


GO
ALTER TABLE [Sales].[GruposDescuentoArticulos] NOCHECK CONSTRAINT [FK_GruposDescuentoArticulos_Articulos]

