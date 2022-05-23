/****** Object:  ForeignKey [FK_UnidadesMedida_UnidadesMedidaTipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[UnidadesMedida]  WITH CHECK ADD  CONSTRAINT [FK_UnidadesMedida_UnidadesMedidaTipos] FOREIGN KEY([IdUnidadMedidaTipo])
REFERENCES [Inventory].[UnidadesMedidaTipos] ([IdUnidadMedidaTipo])


GO
ALTER TABLE [Inventory].[UnidadesMedida] CHECK CONSTRAINT [FK_UnidadesMedida_UnidadesMedidaTipos]

