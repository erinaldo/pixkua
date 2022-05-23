/****** Object:  ForeignKey [FK_ProveedoresArticulos_ArticulosStock]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresArticulos_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])


GO
ALTER TABLE [Purchasing].[ProveedoresArticulos] CHECK CONSTRAINT [FK_ProveedoresArticulos_ArticulosStock]

