/****** Object:  Default [DF_ConceptosCategorias_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[GastosConceptosTipos] ADD  CONSTRAINT [DF_ConceptosCategorias_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


