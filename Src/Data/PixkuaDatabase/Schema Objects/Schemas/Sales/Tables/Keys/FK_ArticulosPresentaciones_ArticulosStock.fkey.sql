/****** Object:  ForeignKey [FK_ArticulosPresentaciones_ArticulosStock]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ArticulosPresentaciones]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosPresentaciones_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])


GO
ALTER TABLE [Sales].[ArticulosPresentaciones] CHECK CONSTRAINT [FK_ArticulosPresentaciones_ArticulosStock]

