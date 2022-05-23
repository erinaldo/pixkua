/****** Object:  ForeignKey [FK_ArticulosStock_UnidadesMedida]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ArticulosStock]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosStock_UnidadesMedida] FOREIGN KEY([IdUnidadMedida])
REFERENCES [Inventory].[UnidadesMedida] ([IdUnidadMedida])


GO
ALTER TABLE [Inventory].[ArticulosStock] CHECK CONSTRAINT [FK_ArticulosStock_UnidadesMedida]

