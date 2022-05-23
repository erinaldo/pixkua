/****** Object:  ForeignKey [FK_Clasificaciones_ClasificacionesGrupos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Clasificaciones]  WITH CHECK ADD  CONSTRAINT [FK_Clasificaciones_ClasificacionesGrupos] FOREIGN KEY([IdClasificacionGrupo])
REFERENCES [Inventory].[ClasificacionesGrupos] ([IdClasificacionGrupo])


GO
ALTER TABLE [Inventory].[Clasificaciones] CHECK CONSTRAINT [FK_Clasificaciones_ClasificacionesGrupos]

