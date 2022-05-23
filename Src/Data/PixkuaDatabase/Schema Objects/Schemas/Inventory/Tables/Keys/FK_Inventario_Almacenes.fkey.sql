/****** Object:  ForeignKey [FK_Inventario_Almacenes]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Almacenes] FOREIGN KEY([IdAlmacen])
REFERENCES [Inventory].[Almacenes] ([IdAlmacen])


GO
ALTER TABLE [Inventory].[Inventario] CHECK CONSTRAINT [FK_Inventario_Almacenes]

