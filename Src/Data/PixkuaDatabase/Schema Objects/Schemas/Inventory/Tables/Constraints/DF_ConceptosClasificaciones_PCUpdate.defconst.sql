/****** Object:  Default [DF_ConceptosClasificaciones_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ConceptosClasificaciones] ADD  CONSTRAINT [DF_ConceptosClasificaciones_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


