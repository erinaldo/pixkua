/****** Object:  ForeignKey [FK_GastosConceptos_ConceptosCategorias]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[GastosConceptos]  WITH CHECK ADD  CONSTRAINT [FK_GastosConceptos_ConceptosCategorias] FOREIGN KEY([IdGastoConceptoTipo])
REFERENCES [Purchasing].[GastosConceptosTipos] ([IdGastoConceptoTipo])


GO
ALTER TABLE [Purchasing].[GastosConceptos] CHECK CONSTRAINT [FK_GastosConceptos_ConceptosCategorias]

