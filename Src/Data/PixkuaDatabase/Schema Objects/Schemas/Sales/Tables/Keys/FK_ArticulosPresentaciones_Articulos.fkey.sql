/****** Object:  ForeignKey [FK_ArticulosPresentaciones_Articulos]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ArticulosPresentaciones]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosPresentaciones_Articulos] FOREIGN KEY([IdArticulo])
REFERENCES [Sales].[Articulos] ([IdArticulo])


GO
ALTER TABLE [Sales].[ArticulosPresentaciones] CHECK CONSTRAINT [FK_ArticulosPresentaciones_Articulos]

