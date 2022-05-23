/****** Object:  ForeignKey [FK_Conceptos_ConceptosClasificaciones]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Conceptos]  WITH CHECK ADD  CONSTRAINT [FK_Conceptos_ConceptosClasificaciones] FOREIGN KEY([IdConceptoClasificacion])
REFERENCES [Inventory].[ConceptosClasificaciones] ([IdConceptoClasificacion])


GO
ALTER TABLE [Inventory].[Conceptos] CHECK CONSTRAINT [FK_Conceptos_ConceptosClasificaciones]

