/****** Object:  ForeignKey [FK_Clasificaciones_ClasificacionesGrupos]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Clasificaciones]  WITH CHECK ADD  CONSTRAINT [FK_Clasificaciones_ClasificacionesGrupos] FOREIGN KEY([IdClasificacionGrupo])
REFERENCES [Sales].[ClasificacionesGrupos] ([IdClasificacionGrupo])


GO
ALTER TABLE [Sales].[Clasificaciones] CHECK CONSTRAINT [FK_Clasificaciones_ClasificacionesGrupos]

