/****** Object:  Default [DF_ClasificacionesGrupos_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ClasificacionesGrupos] ADD  CONSTRAINT [DF_ClasificacionesGrupos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


