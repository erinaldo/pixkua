/****** Object:  ForeignKey [FK_Inventario_ArticulosStock]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])


GO
ALTER TABLE [Inventory].[Inventario] CHECK CONSTRAINT [FK_Inventario_ArticulosStock]

