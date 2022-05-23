/****** Object:  ForeignKey [FK_CentrosRecepcion_Almacenes]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcion]  WITH CHECK ADD  CONSTRAINT [FK_CentrosRecepcion_Almacenes] FOREIGN KEY([IdAlmacen])
REFERENCES [Inventory].[Almacenes] ([IdAlmacen])


GO
ALTER TABLE [Purchasing].[CentrosRecepcion] CHECK CONSTRAINT [FK_CentrosRecepcion_Almacenes]

