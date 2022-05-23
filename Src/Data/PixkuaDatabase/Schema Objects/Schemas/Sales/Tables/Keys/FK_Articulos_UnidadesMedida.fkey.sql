/****** Object:  ForeignKey [FK_Articulos_UnidadesMedida]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_UnidadesMedida] FOREIGN KEY([IdUnidadMedida])
REFERENCES [Inventory].[UnidadesMedida] ([IdUnidadMedida])


GO
ALTER TABLE [Sales].[Articulos] CHECK CONSTRAINT [FK_Articulos_UnidadesMedida]

