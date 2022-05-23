/****** Object:  Default [DF_ConceptosClasificaciones_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ConceptosClasificaciones] ADD  CONSTRAINT [DF_ConceptosClasificaciones_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


