/****** Object:  ForeignKey [FK_ClasificacionesGrupos_ClasificacionesEntidades]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ClasificacionesGrupos]  WITH CHECK ADD  CONSTRAINT [FK_ClasificacionesGrupos_ClasificacionesEntidades] FOREIGN KEY([IdClasificacionEntidad])
REFERENCES [Inventory].[ClasificacionesEntidades] ([IdClasificacionEntidad])


GO
ALTER TABLE [Inventory].[ClasificacionesGrupos] CHECK CONSTRAINT [FK_ClasificacionesGrupos_ClasificacionesEntidades]

