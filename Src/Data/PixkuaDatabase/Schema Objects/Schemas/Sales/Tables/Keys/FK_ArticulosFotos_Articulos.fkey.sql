/****** Object:  ForeignKey [FK_ArticulosFotos_Articulos]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ArticulosFotos]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosFotos_Articulos] FOREIGN KEY([IdArticulo])
REFERENCES [Sales].[Articulos] ([IdArticulo])


GO
ALTER TABLE [Sales].[ArticulosFotos] CHECK CONSTRAINT [FK_ArticulosFotos_Articulos]

