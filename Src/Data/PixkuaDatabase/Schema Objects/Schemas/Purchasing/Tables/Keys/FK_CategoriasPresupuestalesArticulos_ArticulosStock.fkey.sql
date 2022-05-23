/****** Object:  ForeignKey [FK_CategoriasPresupuestalesArticulos_ArticulosStock]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestalesArticulos]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasPresupuestalesArticulos_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])


GO
ALTER TABLE [Purchasing].[CategoriasPresupuestalesArticulos] CHECK CONSTRAINT [FK_CategoriasPresupuestalesArticulos_ArticulosStock]

