/****** Object:  Default [DF_ConceptosClasificaciones_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ConceptosClasificaciones] ADD  CONSTRAINT [DF_ConceptosClasificaciones_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


