/****** Object:  Default [DF_ClasificacionesGrupos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ClasificacionesGrupos] ADD  CONSTRAINT [DF_ClasificacionesGrupos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


